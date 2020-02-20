using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSystem.Common.Exceptions;
using TestSystem.Data.Entites;

namespace TestSystem.Data.Repositories
{
    public class ExamRepository : IExamRepository
    {
        protected readonly DataContext _context;

        public ExamRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Exam>> GetAllAsync()
        {
            return await _context.Exams.ToListAsync();
        }

        public async Task<Exam> GetAsync(long id)
        {
            return await _context.Exams
                .Include(x => x.Questions).ThenInclude(x => x.Answers)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task AddAsync(Exam entity)
        {
            _context.Exams.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Exam entity)
        {
            var currentEntity = await GetAsync(entity.Id);
            if (currentEntity == null)
            {
                throw new InvalidParamsSystemException();
            }

            currentEntity.Name = entity.Name;
            currentEntity.MinutesToComplite = entity.MinutesToComplite;
            currentEntity.Questions = SyncQuestions(entity.Questions, currentEntity.Questions);

            await _context.SaveChangesAsync();
        }

        private IEnumerable<Question> SyncQuestions(IEnumerable<Question> newCollection, IEnumerable<Question> oldCollection)
        {
            foreach (var item in oldCollection)
            {
                var newItem = newCollection.FirstOrDefault(x => x.Id == item.Id);
                if (newItem == null)
                {
                    continue;
                }

                item.Answers = SyncAnswers(newItem.Answers, item.Answers);
            }

            return oldCollection.Where(x => newCollection.Any(y => y.Text == x.Text))
                .Concat(newCollection.Where(x => !oldCollection.Any(y => y.Text == x.Text)));
        }

        private IEnumerable<Answer> SyncAnswers(IEnumerable<Answer> newCollection, IEnumerable<Answer> oldCollection)
        {
            return oldCollection.Where(x => newCollection.Any(y => y.Text == x.Text))
                .Concat(newCollection.Where(x => !oldCollection.Any(y => y.Text == x.Text)));
        }
    }
}
