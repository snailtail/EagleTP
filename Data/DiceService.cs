using System;
using System.Threading.Tasks;

namespace EagleTP.Data
{
    public class DiceService
    {
        
        public Task<int> Roll()
        {
            var rng = new Random();
            int sides = 6;
            int myDice;
            myDice=rng.Next(1,sides+1);
            return Task.FromResult(myDice);
        }


    }
}
