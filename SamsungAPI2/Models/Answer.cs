using System.Collections.Generic;

namespace SamsungAPI2
{
    public class Answer
    {
        public string Text { get; set; }
        
        public int Id { get; set; }
        
        public int Order { get; set; }

        public List<AnswerWeighting> AnswerWeighting { get; set; } = new List<AnswerWeighting>();
    }
}