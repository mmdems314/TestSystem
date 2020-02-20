using System.Collections.Generic;
using System.Threading.Tasks;
using TestSystem.Data.Entites;

namespace TestSystem.Data.Repositories
{
    public interface IExamRepository
    {
        Task<IEnumerable<Exam>> GetAllAsync();

        Task<Exam> GetAsync(long id);

        Task AddAsync(Exam entity);

        Task UpdateAsync(Exam entity)
    }
}
