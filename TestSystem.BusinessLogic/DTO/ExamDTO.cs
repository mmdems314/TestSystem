using System.Collections.Generic;

namespace TestSystem.BusinessLogic.DTO
{
    public class ExamDTO
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public int MinutesToComplite { get; set; }

        public IEnumerable<QuestionDTO> Questions { get; set; } = new List<QuestionDTO>();
    }
}
