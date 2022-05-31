using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahmini
{

    
    internal class RandomNumber
    {

        public int Estimation()
        {
            Random random = new Random();

            int randomNumber = random.Next(0, 20);


            return randomNumber;
        }
    }
}
