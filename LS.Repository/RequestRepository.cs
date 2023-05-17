using LS.Model;
using LS.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace LS.Repository
{
    public class RequestRepository : BaseRepository<Request>, IRequestRepository
    {
        public RequestRepository(LSContext context) : base(context)
        {
               
        }

        public Request GetByID(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Zero ID");

            return base.GetByID(id);
        }


    }
}