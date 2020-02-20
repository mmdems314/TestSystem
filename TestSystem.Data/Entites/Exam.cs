using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestSystem.Data.Entites
{
    public class Exam
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        public int MinutesToComplite { get; set; }

        public IEnumerable<Question> Questions { get; set; } = new List<Question>();
    }
}
