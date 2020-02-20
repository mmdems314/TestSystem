using AutoMapper;
using TestSystem.BusinessLogic.DTO;
using TestSystem.Data.Entites;

namespace TestSystem.BusinessLogic.MapperProfiles
{
    public class ExamProfile : Profile
    {
        public ExamProfile()
        {
            CreateMap<Answer, AnswerDTO>();
            CreateMap<AnswerDTO, Answer>();
            CreateMap<Question, QuestionDTO>();
            CreateMap<QuestionDTO, Question>();
            CreateMap<Exam, ExamDTO>();
            CreateMap<ExamDTO, Exam>();
        }
    }
}
