using LS.Model;
using LS.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace LS.Repository
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(LSContext context) : base(context)
        {
               
        }

        public Department GetByID(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Zero ID");

            return base.GetByID(id);
        }


    }
}