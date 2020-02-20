using AutoMapper;
using System.Threading.Tasks;
using TestSystem.BusinessLogic.DTO;
using TestSystem.Data.Entites;
using TestSystem.Data.Repositories;

namespace TestSystem.BusinessLogic.Managers
{
    public class ExamManager
    {
        protected readonly ExamRepository _examRepository;

        protected readonly IMapper _mapper;

        public ExamManager(ExamRepository examRepository, IMapper mapper)
        {
            _examRepository = examRepository;
            _mapper = mapper;
        }

        public async Task AddAsync(ExamDTO exam)
        {
            var entity = _mapper.Map<Exam>(exam);
            await _examRepository.AddAsync(entity);
        }

        public async Task UpdateAsync(ExamDTO exam)
        {
            var entity = _mapper.Map<Exam>(exam);
            await _examRepository.AddAsync(entity);
        }

    }
}
