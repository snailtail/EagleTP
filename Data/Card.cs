using System;
using System.Threading.Tasks;

namespace EagleTP.Data
{

    public class Card
    {
        
        public Task<question> ReadCard()
        {
            var rng = new Random();
            question _question = new question();
            _question.ID = rng.Next(99);
            _question.Question="Randomized question string [" + rng.Next(6).ToString() + "]";
            _question.Answer="Carbonized answer string [!" + rng.Next(-8,-1).ToString() + "]";
            return Task.FromResult(_question);

        }

    }

    public class question
    {
        public int ID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }

}