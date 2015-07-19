using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2_1
{
    class Box
    {
    double a;
    double b;
    double c;
    float _A;
    float _B;

    public Box(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double Area
    {
        get { return 2 * (this.a * this.b + this.a * this.c + this.b * this.c); }
    }
    public double V
    {
        get { return this.a * this.b * this.c; }
    }
    public double Diagonal()
    {
        return Math.Pow(Math.Pow(this.a, 2) + Math.Pow(this.b, 2) + Math.Pow(this.c, 2), 0.5);
    }
    public void Sround(float A, float B)
    {
        _A = A;
        _B = B;
        if (A > B || A == B)
        {
            double P;
            P = Math.PI * Math.Pow(0.5 * B, 2);
            Console.WriteLine("Площадь круга в данной грани: {0:g5}", P);
        }
        else
        {
            double P;
            P = Math.PI * Math.Pow(0.5 * A, 2);
            Console.WriteLine("Площадь круга в данной грани: {0:g5}", P);
        }
    }
    public void DisplayShow()
    {
        Console.WriteLine("данные о параллелепипеде:\n" + "a=" + a + "\nb=" + b + "\nc=" + c + "\nПлощадь граней=" + Area + "\nОбъём=" + V);
    }
}}
