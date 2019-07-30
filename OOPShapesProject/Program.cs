using System;

namespace OOPShapesProject {
    class Program {
        static void Main(string[] args) {
            var quad1 = new Quad(5, 7, 13, 6);
            
            var perimeter = quad1.GetPerimeter();
            Console.WriteLine($"The quad Perimeter is { perimeter}m");
            var rect1 = new Rect(5, 13);
            perimeter = rect1.GetPerimeter();
            Console.WriteLine($"The rect Perimeter is { perimeter}m");
            var Square = new Square(7);
            perimeter = Square.GetPerimeter();
            Console.WriteLine($"The square perimeter is {perimeter}m");
        }
    }
}
