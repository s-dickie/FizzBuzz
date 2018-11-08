using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
   public class FizzBuzzConverter
    {


        public string Implementation(int input)
        {

            int modularoutputdividebythree =  input % 3;
            int modularoutputdividebyfive = input % 5;
            string outputthree = "Fizz";
            string outputfive = "Buzz";
            string output = "";


            if ((modularoutputdividebythree == 0) & (modularoutputdividebyfive == 0))
            {
                output = outputthree + outputfive;
            }

            else if ((modularoutputdividebythree == 0) & (modularoutputdividebyfive != 0))
            {
                output = outputthree;
            }
            else if ((modularoutputdividebythree != 0) & (modularoutputdividebyfive == 0))

            {
                output = outputfive;
            }
            else
            {
                output = input.ToString();
            }
                        
            return output;

            
        }
    }
}
