using System;
class Circle
{
    static float Pi;
    int radius;
    static Circle() //static constructor do not require access modifier, used to initialise static field
    {
        Console.WriteLine("static constructor is called automatically only one time");
        Circle.Pi = 3.14F;
    }
    public Circle(int r)//instance constructor require access modifier,used to initialise non static field
    {
        Console.WriteLine("instance constructor called");
        this.radius = r;// instance constructor is called n times if n object are created for the class
    }
    public float Area()
    {
        return Circle.Pi * this.radius * this.radius;//to access static field we are using classname.staticfield name
    }// but for radius we dont require classname as it is instance field or non static field;
}
class Program
{
    public static void Main()
    {
        Circle c1 = new(5);//so first thing happen inside main will be automatically calling static constructor first only one time
        float b = c1.Area();
        Console.WriteLine(b);

        Circle c2 = new(6);
        float d = c2.Area();
        Console.WriteLine(d);
    }
}
