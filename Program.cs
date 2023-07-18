using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFigure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int figure=0;
            double perimeter = 0.0;
            double square = 0.0;
            Console.WriteLine("Оберіть фігуру: 1- коло, 2- чотирикутник, 3- трикутник");
            bool valid = int.TryParse(Console.ReadLine().Trim(), out int input);
            if (!valid||input>3||input<=0) Console.WriteLine("Не вірно обрана фігура");
            else figure = input;
            switch (figure)
            {
                case 1:
                    double radius=0;
                    Console.Write(" Введіть радіус кола, см");
                    bool valid1 = double.TryParse(Console.ReadLine().Trim(), out double input1);
                    if (!valid1 || input1 <= 0) Console.WriteLine("Не вірно введені дані. Потрібне число");
                    else
                    {
                        radius = input1;
                        double Pi;
                        Pi = 3.1415926;
                        perimeter = 2 * Pi * radius;
                        square = Pi * (radius * radius);
                        Console.WriteLine($"Площа кола = {square} см; периметр = {perimeter}см");
                    }
                    break;
                case 2:
                    double OneSide=0.0;
                    double SecondSide=0.0;
                    Console.WriteLine(" Введіть першу сторону чотирикутника, см");
                    bool valid2 = double.TryParse(Console.ReadLine().Trim(), out double input2);
                    if (!valid2 || input2 <= 0) { Console.WriteLine("Не вірно введені дані. Потрібне число"); }
                    else
                    {
                        OneSide = input2;
                        Console.WriteLine(" Введіть другу сторону чотирикутника, см");
                        bool valid3 = double.TryParse(Console.ReadLine().Trim(), out double input3);
                        if (!valid3 || input3 <= 0) { Console.WriteLine("Не вірно введені дані. Потрібне число"); }
                        else
                        {
                            SecondSide = input3;
                            perimeter = 2 * OneSide + 2 * SecondSide;
                            square = OneSide * SecondSide;
                            Console.WriteLine($"Площа чотирикутника = {square} см; периметр = {perimeter} см");
                        }
                    }
                    break;
                case 3:
                    double OneSideT = 0.0;
                    double SecondSideT = 0.0;
                    double ThirdSideT = 0.0;
                    Console.WriteLine(" Введіть першу сторону трикутника, см");
                    bool valid4 = double.TryParse(Console.ReadLine().Trim(), out double input4);
                    if (!valid4 || input4 <= 0) { Console.WriteLine("Не вірно введені дані. Потрібне число"); }
                    else
                    {
                        OneSideT = input4;
                        Console.WriteLine(" Введіть другу сторону трикутника, см");
                        bool valid5 = double.TryParse(Console.ReadLine().Trim(), out double input5);
                        if (!valid5 || input5 <= 0) Console.WriteLine("Не вірно введені дані. Потрібне число");
                        else
                        {
                            SecondSideT = input5;
                            Console.WriteLine(" Введіть третю сторону трикутника, см");
                            bool valid6 = double.TryParse(Console.ReadLine().Trim(), out double input6);
                            if (!valid6 || input6 <= 0) { Console.WriteLine("Не вірно введені дані. Потрібне число"); }
                            else
                            {
                                ThirdSideT = input6;

                                if (OneSideT + SecondSideT < ThirdSideT && OneSideT + ThirdSideT < SecondSideT && SecondSideT + ThirdSideT < OneSideT)
                                {
                                    perimeter = OneSideT + SecondSideT + ThirdSideT;
                                    double DivTwoPerimeter = perimeter / 2 * (perimeter / 2 - OneSideT) * (perimeter / 2 - SecondSideT) * (perimeter / 2 - ThirdSideT);
                                    square = Math.Sqrt(DivTwoPerimeter);
                                    Console.WriteLine($"Площа трикутника = {square} см; периметр = {perimeter} см");
                                }
                                else
                                {
                                    Console.WriteLine("Не вірно задані сторони. Такого трикутника не існує");
                                }
                            }
                        }
                    }
                        break;
                    
                

            }
            Console.ReadKey(true);

        }
    }
}
