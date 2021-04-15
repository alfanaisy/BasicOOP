using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu1 menu1 = new Menu1();
            Menu2 menu2 = new Menu2();
            Menu3 menu3 = new Menu3();
            Menu4 menu4 = new Menu4();

            string confirm = "yes";

            while (confirm == "yes")
            {
                Console.WriteLine(
                        "------ Input Number from 1-4 ------" +
                        "\n1. Body Mass Index" +
                        "\n2. Reprint Name" +
                        "\n3. Print Even's Character" +
                        "\n4. Sum the inputted array"
                    );
                Console.WriteLine("Choose menu:");
                try
                {
                    int menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Input weight: ");
                            menu1.Weight = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Input height: ");
                            menu1.Height = Convert.ToInt32(Console.ReadLine());
                            float bmi = menu1.HitungBMI();
                            if (bmi < 18.1)
                            {
                                Console.WriteLine("BMI : " + bmi.ToString("F2") + ". You're Underweight");
                            }
                            else if (bmi < 23.1)
                            {
                                Console.WriteLine("BMI : " + bmi.ToString("F2") + ". You're Normal");
                            }
                            else if (bmi < 28.1)
                            {
                                Console.WriteLine("BMI : " + bmi.ToString("F2") + ". You're Overweight");
                            }
                            else
                            {
                                Console.WriteLine("BMI : " + bmi.ToString("F2") + ". You're Obese");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Input name : ");
                            menu2.Name = Console.ReadLine();
                            menu2.reprintName();
                            break;
                        case 3:
                            Console.WriteLine("Input name : ");
                            menu3.Name = Console.ReadLine();
                            menu3.getEvenChar();
                            break;
                        case 4:
                            Console.WriteLine("Input length : ");
                            menu4.ArrLength = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("sum : "+ menu4.sumArray());
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please input a number only!");
                }
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Type \"Yes\" to continue program");
                confirm = Console.ReadLine().ToLower();
                Console.Clear();
            }
        }
    }
}
