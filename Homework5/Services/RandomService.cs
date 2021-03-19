using System;
namespace Homework5.Models
{
    public class RandomService : RandomInt
    {
        public RandomService()
        {
            Random rand = new Random();
            RandomInt = rand.Next(1,1000);
        }
        public int RandomInt { get; }
    }
}