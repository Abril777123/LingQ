using System;
using System.Collections.Generic;

class LingQ
{
    public string Palabra { get; set; }
    public string Definicion { get; set; }

    public LingQ(string palabra, string definicion)
    {
        Palabra = palabra;
        Definicion = definicion;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<LingQ> lingqs = new List<LingQ>();

        string texto = "Esta es una oración de ejemplo para crear LingQs.";
        string[] palabras = texto.Split();

        foreach (string palabra in palabras)
        {
            if (!palabra.EndsWith(".") && !palabra.EndsWith(",") && !palabra.EndsWith("!") && !palabra.EndsWith("?"))
            {
                Console.WriteLine($"Ingrese la definición de '{palabra}':");
                string definicion = Console.ReadLine();
                LingQ lingq = new LingQ(palabra, definicion);
                lingqs.Add(lingq);
            }
        }

        Console.WriteLine("------------------");
        foreach (LingQ lingq in lingqs)
        {
            Console.WriteLine($"Palabra: {lingq.Palabra}");
            Console.WriteLine($"Definición: {lingq.Definicion}");
            Console.WriteLine("------------------");
        }
    }
}