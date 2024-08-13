Imports System

Module Program
        Sub Main()
            Console.WriteLine("ingresa la frecuencia")
            Dim F As Single = Console.ReadLine()
            Console.WriteLine("ingrese el valor de la bobina")
            Dim L As Single = Console.ReadLine()
            Console.WriteLine("ingrese el valor del capacitor")
            Dim C As Single = Console.ReadLine()
            Console.WriteLine("ingrese el valor de la resistencia")
            Dim R As Single = Console.ReadLine
            Dim XL As Single = (2 * 3.14 * F * L)
            Dim XC As Single = (1 / (2 * 3.14 * F * C))
        Dim X As Single
        X = (XL - XC)
        Dim Z As Single = Math.Sqrt((R * R) + (X * X))
        Dim A As Single = Math.Atan((XL - XC) / (R))
        Console.WriteLine("la reactancia inductiva es" & XL)
        Console.WriteLine("la reactancia capacitiva es" & XC)
        Console.WriteLine("X es" & X)
        Console.WriteLine("la resistencia es:" & R)
        Console.WriteLine("la impedancia es" & Z)
        Console.WriteLine("el Ángulo es:" & A)
    End Sub

    End Module

