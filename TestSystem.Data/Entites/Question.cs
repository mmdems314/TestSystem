using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestSystem.Data.Entites
{
    public class Question
    {
        [Key]
        public long Id { get; set; }

        public string Text { get; set; }

        public long ExamId { get; set; }

        [ForeignKey(nameof(ExamId))]
        public Exam Exam { get; set; }

        public IEnumerable<Answer> Answers { get; set; } = new List<Answer>();
    }
}
