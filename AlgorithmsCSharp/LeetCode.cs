using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCSharp
{
    public class LeetCode
    {
        public static bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            return !(rec1[2] <= rec2[0] || //left
                rec1[3] <= rec2[1] || //bottom
                rec1[0] >= rec2[2] || //right
                rec1[1] >= rec1[3]    //top
                );
        }

        public static IList<string> FizzBuzz(int n) 
        {
            var numberList = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                bool multipleOfThree = (i % 3 == 0);
                bool multipleOfFive = (i % 5 == 0);

                if (multipleOfThree && multipleOfFive)
                {
                    numberList.Add("FizzBuzz");
                }
                else if (multipleOfThree)
                {
                    numberList.Add("Fizz");
                }
                else if (multipleOfFive)
                {
                    numberList.Add("Buzz");
                }
                else
                {
                    numberList.Add(i.ToString());
                }
            }

            return numberList;
        }
    }
}
