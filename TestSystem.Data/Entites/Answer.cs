using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestSystem.Data.Entites
{
    public class Answer
    {
        [Key]
        public long Id { get; set; }

        public string Text { get; set; }

        public bool IsCorrect { get; set; }

        public long QuestionId { get; set; }

        [ForeignKey(nameof(QuestionId))]
        public Question Question { get; set; }
    }
}
