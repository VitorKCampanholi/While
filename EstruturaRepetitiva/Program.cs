﻿using System.Globalization;


    Console.Write("Digite um numero: ");
    double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    while (x >= 0.0) {

    double raiz = Math.Sqrt(x);
 
    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
    Console.Write("Digite outro Número : ");
    x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


}
    Console.WriteLine("Numero negativo");
    