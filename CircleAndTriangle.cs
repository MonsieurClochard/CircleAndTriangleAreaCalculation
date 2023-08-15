using System.Text.RegularExpressions;

namespace CircleAndTriangleAreaCalculation
{
    public class CircleAndTriangle
    {
        //Меню вызова вычисления
        public static void CircleAndTriangleMenu()
        {
            Console.WriteLine("Please select an action");
            Console.WriteLine("1: Circle area calculating");
            Console.WriteLine("2: Triangle area calculating");

            string? userInupt = Console.ReadLine();
            if (userInupt != "1" && userInupt != "2")
            {
                Console.WriteLine("Invalid selection!!!");
                return;
            }

            switch (userInupt)
            {
                case "1":
                    CircleCalculating();
                    break;
                case "2":
                    TriangleCalculating();
                    break;
            }
        }

        //Логика вычисления круга
        public static void CircleCalculating()
        {
            Console.WriteLine("Please enter the radius of circle: ");
            string? userInput = Console.ReadLine();
            double radius = double.Parse(userInput);

            double circleArea = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Area of circle is: " + circleArea);

            Console.WriteLine("\n");
            CircleAndTriangleMenu();
        }

        //Логика вычисления треугольника
        public static void TriangleCalculating()
        {
            Console.WriteLine("Please enter the radius of circle: ");
            string? sideInput1 = Console.ReadLine();
            double input1 = double.Parse(sideInput1);

            string? sideInput2 = Console.ReadLine();
            double input2 = double.Parse(sideInput2);

            string? sideInput3 = Console.ReadLine();
            double input3 = double.Parse(sideInput3);

            double semiPerimeter = input1 + input2 + input3 / 2;
            
            double triangleArea = Math.Sqrt(semiPerimeter * (semiPerimeter - input1) * (semiPerimeter - input2) * (semiPerimeter - input3));
            Console.WriteLine("Area of triangle is: " + triangleArea);
            
            Console.WriteLine("\n");
            CircleAndTriangleMenu();
        }
        //
        //        SELECT s1.subject,
        //       s2.subject
        //FROM   survey s1
        //       JOIN survey s2
        //         ON s1.subject<s2.subject
        //GROUP  BY s1.subject,
        //        s2.subject
        //HAVING COUNT(CASE
        //               WHEN s1.groupid = s2.groupid THEN 1
        //             END) = 0  
    }
}