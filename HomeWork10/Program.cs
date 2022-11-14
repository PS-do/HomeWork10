using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle angel;
            do
            {
                Console.WriteLine("Введите данные");
                Console.Write("Градусы:");
                int gradus_ = Convert.ToInt32(Console.ReadLine());

                Console.Write("Минуты:");
                int min_ = Convert.ToInt32(Console.ReadLine());

                Console.Write("Секунды:");
                int sec_ = Convert.ToInt32(Console.ReadLine());
                angel = new Angle(gradus_, min_, sec_);
            } while (angel.isCorrect == false);
            
            Console.WriteLine(angel.ToRadian());
            Console.ReadKey();

        }
    }
}
