using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5
{
 internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Звичайний конструктор: ");
            TCircle circle1 = new TCircle();
            circle1.setInfo();
            circle1.getInfo();
            Console.WriteLine("Визначення площi круга: ");
            Console.WriteLine("Square of this circle = " + circle1.getSquare());
            Console.WriteLine("Визначення довжини кола: ");
            Console.WriteLine("Length of this circle = " + circle1.getLength());
            Console.WriteLine("Конструктор з параметрами: ");
            TCircle circle2 = new TCircle(5);
            circle2.getInfo();
            Console.WriteLine("Порiвняння двох кiл: ");
            circle1.compare((TCircle)circle2);
            Console.WriteLine("Додавання радiусiв: ");
            TCircle circle3 = circle2 + 2;
            circle3.getInfo();
            Console.WriteLine("Вiднiмання радiусiв: ");
            TCircle circle4 = circle2 - 3;
            circle4.getInfo();
            Console.WriteLine("Множення радiуса на число: ");
            TCircle circle5 = circle2 * 2;
            circle5.getInfo();
            Console.WriteLine("Конструктор копiювання: ");
            TCircle circle6 = new TCircle(circle5);
            circle6.getInfo();
            Console.WriteLine("Звичайний конструктор TCylinder: ");
            TCylinder cylinder1 = new TCylinder();
            cylinder1.setInfo();
            cylinder1.getInfo();
            Console.WriteLine("Визначення площi основи цiлiндра: ");
            Console.WriteLine("Square of this circle = " + cylinder1.getSquare());
            Console.WriteLine("Визначення довжини основи цiлiндра: ");
            Console.WriteLine("Length of this circle = " + cylinder1.getLength());
            Console.WriteLine("Визначення об'єма цiлiндра: ");
            Console.WriteLine("Volume of this circle = " + cylinder1.getVolume());
            Console.WriteLine("Конструктор з параметрами TCylinder: ");
            TCylinder cylinder2 = new TCylinder(5, 5);
            cylinder2.getInfo();
            Console.WriteLine("Порiвняння двох цiлiндрiв: ");
            cylinder1.compare((TCircle)cylinder2);
            Console.WriteLine("Конструктор копiювання TCylinder: ");
            TCylinder cylinder3 = new TCylinder(cylinder2);
            cylinder3.getInfo();
        }
    }
}

class TCircle
{
    protected double radius;
    public TCircle()
    {
        
    }

    public TCircle(double radius)
    {
        this.radius = radius;
    }

    public TCircle(TCircle another)
    {
        this.radius = another.radius;
    }

    public virtual void setInfo()
    {
        Console.WriteLine("Type radius of this circle: ");
        radius = Convert.ToDouble(Console.ReadLine());
    }
    public virtual void getInfo()
    {
        Console.WriteLine("Radius of this circle = " + radius + ".");
    }

    public double getSquare()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public double getLength()
    {
        return 2 * Math.PI * radius;
    }

    public virtual void compare(TCircle another)
    {
        if(this.radius > another.radius)
            Console.WriteLine("Radius of this circle is bigger than radius of comparable circle.");
        else if(this.radius < another.radius)
            Console.WriteLine("Radius of this circle is smaller than radius of comparable circle.");
        else
            Console.WriteLine("Radiuses of both circles are equal");
    }

    public virtual double getVolume()
    {
        return 0;
    }

    public static TCircle operator +(TCircle circle1, double radius) => new TCircle(circle1.radius + radius);

    public static TCircle operator -(TCircle circle1, double radius) => new TCircle(circle1.radius - radius);

    public static TCircle operator *(TCircle circle1, double num) => new TCircle(circle1.radius * num);
}

class TCylinder: TCircle
{
    protected double h;

    public TCylinder()
    {

    }

    public TCylinder(double radius, double h)
    {
        this.radius = radius;
        this.h = h;
    }

    public TCylinder(TCylinder another)
    {
        this.radius = another.radius;
        this.h = another.h;
    }

    public override void setInfo()
    {
        Console.WriteLine("Type radius of this cylinder: ");
        radius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Type height of this cylinder: ");
        h = Convert.ToDouble(Console.ReadLine());
    }
    
    public override void getInfo()
    {
        Console.WriteLine("Radius of this cylinder = " + radius + ".");
        Console.WriteLine("Height of this cylinder = " + h + ".");
    }
    
    public override void compare(TCircle another)
    {
        if (this.getVolume() > another.getVolume())
            Console.WriteLine("Volume of this circle is bigger than volume of comparable circle.");
        else if (this.getVolume() < another.getVolume())
            Console.WriteLine("Volume of this circle is smaller than volume of comparable circle.");
        else
            Console.WriteLine("Volumes of both circles are equal"); ;
    }
    public override double getVolume()
    {
        return this.getSquare() * h;
    }
}
