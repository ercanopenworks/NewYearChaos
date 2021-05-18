using System;

namespace NewYearChaos
{
    class Program
    {
        static void minimumBribes(int[] q)
        {
            int bribe = 0;
            
            for(int i=q.Length-1; i>0; i--)
            {
                if(q[i]==(i+1))
                {

                }
                else if (q[i-1] ==(i+1))
                {
                    bribe++;
                    q[i - 1] = q[i];
                }
                else if (q[i-2] == (i+1))
                {
                    bribe += 2;
                    q[i - 2] = q[i - 1];
                    q[i - 1] = q[i];
                }
                else
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
            }

            Console.WriteLine(bribe.ToString());

        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));

                minimumBribes(q);
            }
        }
    }
}
