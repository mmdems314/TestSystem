using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSystem.Data.Entites;

namespace TestSystem.Data.Repositories
{
    public class ExamResultRepository
    {
        protected readonly DataContext _context;

        public ExamResultRepository(DataContext context)
        {
            _context = context;
        }

        public async Task AddAsync(ExamResult entity)
        {
            _context.ExamResults.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ExamResult>> GetAllAsync()
        {
            return await _context.ExamResults.ToListAsync();
        }

        public async Task<IEnumerable<ExamResult>> GetAllAsync(string userId)
        {
            return await _context.ExamResults.Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
