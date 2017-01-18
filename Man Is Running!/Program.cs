using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Man_Is_Running_
{
    class Program
    {
       public static int t;

        static void Main(string[] args)
        {
            Console.WriteLine("你是一个码农!\n你遇到了怪兽!\n你开始了攻击!\n请输入你的攻击力!");
            try
            {
                string input = Console.ReadLine();
                int dmg = Convert.ToInt32(input);
                Console.WriteLine("你的攻击对怪兽造成了{0}点伤害", dmg);
                t = 1;
                System.Threading.Thread.Sleep(000);
                EndingCheck();
            }
            catch
            {
                t = 0;
                Console.WriteLine("攻击非法!\n");
                EndingCheck();
            }
        }
        static void EndingCheck()
        {
            switch (t)
            {
                case 0:
                    Console.WriteLine("你死了");
                    break;
                case 1:
                    Console.WriteLine("Good Ending");
                    break;
                case 2:
                    Console.WriteLine("Bad Ending");
                    break;
                default:
                    Console.WriteLine("?");
                    break;
            }
        }
    }
}
