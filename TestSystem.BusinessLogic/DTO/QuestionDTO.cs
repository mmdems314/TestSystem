using System;
using System.Collections.Generic;
using System.Text;

namespace TestSystem.BusinessLogic.DTO
{
    public class QuestionDTO
    {
        public long Id { get; set; }

        public string Text { get; set; }

        public IEnumerable<AnswerDTO> Answers { get; set; } = new List<AnswerDTO>();
    }
}
