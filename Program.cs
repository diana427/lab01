﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Cilindr
{
    private double radius_osnovania, vysota; // радиус основания и высота

    public double get_radius() //получаем радиус
    {
        return radius_osnovania;
    }
    public void set_radius(double value_radius) //задаём радиус
    {
        radius_osnovania = value_radius;
    }
    public double get_vysota() //получаем высоту
    {
        return vysota;
    }
    public void set_vysota(double value_vysota) //задаём высоту
    {
        vysota = value_vysota;
    }
    public Cilindr(double r, double h)
    {
        radius_osnovania = r;
        vysota = h;
    }
    public double Obyem()
    {
        return Math.PI * Math.Pow(radius_osnovania, 2) * vysota;
    }
    public void vyvod()
    {
        Console.WriteLine("Радиус= {0,5:f3} Высота= {1,5:f3}",
        radius_osnovania, vysota);
    }
  
}
class Program
{

    static void Main(string[] args)
    {
        Cilindr C1 = new Cilindr(4, 12); //перший циліндр

        Console.WriteLine("Програма, яка розраховує об'єм цилiндра: \n");
        Console.WriteLine("Радiус= {0,5:f3} Висота= {1,5:f3}",
        C1.get_radius(), C1.get_vysota());
        Console.WriteLine("Об'єм цилiндра:{0,5:f3}", C1.Obyem());

        Console.WriteLine("\nВведите радиус основания и высоту третьего цилиндра");
        Cilindr C2 = new Cilindr(Convert.ToDouble(Console.ReadLine()),
         Convert.ToDouble(Console.ReadLine()));
        //радіус і висота другого цилінда
        C2.vyvod();
        Console.WriteLine(C2.Obyem());

        Console.ReadKey();
    }
}



