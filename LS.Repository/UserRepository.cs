using LS.Model;
using LS.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace LS.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(LSContext context) : base(context)
        {
               
        }

        public User Auntheticate(string username, string password)
        {
            if (username == null || password == null)
                throw new UnauthorizedAccessException("");


            var user = this.DbContext.User.SingleOrDefault(j => j.UserName == username);

            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
                throw new UnauthorizedAccessException("");


            return user;
        }

        public User Register(User user)
        {
            // validate
            if (this.DbContext.User.Any(j => j.UserName == user.UserName))
                throw new ArgumentException("Username '" + user.UserName + "' is already taken");

            // hash password
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

            // save user
            this.DbContext.User.Add(user);
            this.DbContext.SaveChanges();
            return user; 
        }


        public User UpdateUserPass(int userID, User user)
        {
            var retUser = this.DbContext.User.SingleOrDefault(j => j.UserID == userID);

            // validate
            if (user.UserName != retUser.UserName && this.DbContext.User.Any(j => j.UserName == user.UserName))
                throw new ArgumentException("Username '" + user.UserName + "' is already taken");


            // hash password if it was entered
            if (!string.IsNullOrEmpty(user.Password))
                retUser.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

            // copy model to user and save
            this.DbContext.User.Update(user);
            SaveChanges();

            return retUser;
        }

    }
}