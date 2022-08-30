using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipACoin
{
    public class FlipCoin
    {

        public void Flip()
        {

            Console.WriteLine("Enter How many times to flip coin");
            double n = Double.Parse(Console.ReadLine());

            int h_count = 0;
            int t_count = 0;

            for (int i = 1; i <= n; i++)
            {
                Random random = new Random();

                int head_or_tail = random.Next(0, 2);// taking random Head or Tail for head 1 and tail = 0

                if (head_or_tail == 1)
                {
                    Console.WriteLine("Heads");
                    h_count++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    t_count++;
                }
            }
            Console.WriteLine("no of heads " +h_count);
            Console.WriteLine("no of tails " +t_count);

            double Head_percentage = (h_count/n) * 100;
            double Tail_Percentage = (t_count/n) * 100;

            Console.WriteLine("Percentage of Heads is = {0}%", Head_percentage);
            Console.WriteLine("Percentage of Tails is = {0}% ", Tail_Percentage);

        }
    }
}

