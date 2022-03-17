using ChrisBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisBook.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj); // This is added separately from IRepository where all the other functionalities are implemented
    }
}
// Update Save above are just function name whose codes are implemented in CategoryRepository.