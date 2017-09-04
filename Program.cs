using System;

namespace CShapeProject
{
    class MainClass
    {
        static CShape[] shapes = new CShape[50];
        static int count = 0;
        public static void Main(string[] args)
        {
            int option;

            while (true) {
                Console.WriteLine("1)add, 2)output, -1)quit;");
                option = int.Parse(Console.ReadLine());

                if (option == -1)
                    break;
                else if (option == 1)
                    Add();
                else if (option == 2){
                    for (int i = 0; i < count; i++)
                        Console.WriteLine("Area of shape:{0:F2}, perimeter:{1:F2}", shapes[i].ComputeArea(), shapes[i].ComputePerimeter());
				}
                else
                    Console.WriteLine("Input error!");
            }
        }

        public static void Add(){
            string input;
            Console.WriteLine("1)Circle, 2)Rectangle, 3)Trapezoid, -1)Back:");
            int option = int.Parse(Console.ReadLine());
            if (option == -1) { }
            else
            {
                if (count >= shapes.Length)
                    Array.Copy(shapes, shapes, count * 2);
                if (option == 1)
                {
                    Console.WriteLine("Radius:");
                    input = Console.ReadLine();
                    double r = Double.Parse(input);
                    shapes[count++] = (CShape)(new CCircle(r));
                }
                else if (option == 2){
                    Console.WriteLine("Wide, height:");
                    input = Console.ReadLine();
                    string[] temp = input.Split(' ');
                    double w = Double.Parse(temp[0]), h = Double.Parse(temp[1]);
                    shapes[count++] = (CShape)(new CRectangle(w, h));
                }
                else if (option == 3){
                    Console.WriteLine("Upperbase, lowerbase, height:");
                    input = Console.ReadLine();
                    string[] temp = input.Split(' ');
                    double u = Double.Parse(temp[0]), l = Double.Parse(temp[1]), h = Double.Parse(temp[2]);
                    shapes[count++] = (CShape)(new CTrapezoid(u, l, h));
                }
                else
                    Console.WriteLine("Input error!");
            }
        }
    }
}
