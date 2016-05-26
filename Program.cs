using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadratic_eqn
{
    class Program
    {
        static void Main(string[] args)
        {
           
                double a;
                double b;
                double c;

                double square_b;
                double neg_b;
                double two_a;
                double neg_four_a_c;
                double square_b_minus_4ac;
                double root_of_square_b_4ac;
                double upper_calc_one;
                double upper_calc_two;
                double x_one;
                double x_two;

                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());

                square_b = b * b;
                neg_b = b * (-1);
                two_a = 2 * a;
                neg_four_a_c = 4 * a * c * (-1);
                square_b_minus_4ac = square_b - neg_four_a_c;

                if (square_b_minus_4ac < 0)
                    Console.WriteLine(" quadratic equation has no solution");
                else
                {
                    root_of_square_b_4ac = Math.Sqrt(square_b_minus_4ac);
                    upper_calc_one = neg_b + root_of_square_b_4ac;
                    upper_calc_two = neg_b - root_of_square_b_4ac;

                    x_one = upper_calc_one / two_a;
                    x_two = upper_calc_two / two_a;


                    Console.WriteLine("x1= {0}", x_one);
                    Console.WriteLine("x2= {0}", x_two);
                    Console.ReadLine();
                }
            }
           
        }
    }
}
