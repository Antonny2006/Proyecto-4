// See https://aka.ms/new-console-template for more information

using System;

class super_mercado
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a mi pequeño super mercado");
        Console.WriteLine("Por Favor ingrese su Nombre");
        string Nombre = Console.ReadLine();

        Console.WriteLine("Por Favor ingrese su Edad");
        int Edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Elija la categoria del producto");
        Console.WriteLine("1. Bebidas");
        Console.WriteLine("2. Carnes");
        Console.WriteLine("3. Churros");
        string categoria = Console.ReadLine();
        int subtotal = 0;
        double descuento = 0;
        double total = 0;

        if (categoria == "1")
        {
            Console.WriteLine("1. Agua");
            Console.WriteLine("2. Jugo de Naranja");
            Console.WriteLine("3. Jugo de piña");
            Console.WriteLine("4. Refresco");
            Console.WriteLine("5. Cafe");
            string Bebida = Console.ReadLine();

            if (Bebida == "1")
            {
                Console.WriteLine("1. Normal");
                Console.WriteLine("2. Mediano");
                Console.WriteLine("3. Grande");
                string bebida = Console.ReadLine();
                int precio = bebida == "1" ? 13 : bebida == "2" ? 15 : 20;
                Console.WriteLine($"Ingrese la cantidad de Agua {bebida} a comprar");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                subtotal = cantidad * precio;
            }
        }
        else if (categoria == "2")
        {
            Console.WriteLine("1. Carne Roja");
            Console.WriteLine("2. Carne de Res");
            Console.WriteLine("3. Carne de Cerdo");
            Console.WriteLine("4. Carne blanca");
            Console.WriteLine("5. Carne Molida");
            string Carne = Console.ReadLine();

            if (Carne == "1")
            {
                Console.WriteLine("1. Normal");
                Console.WriteLine("2. Mediano");
                Console.WriteLine("3. Grande");
                string carne = Console.ReadLine();
                int precio = carne == "1" ? 80 : carne == "2" ? 85 : 90;
                Console.WriteLine($"Ingrese la cantidad de Carne Roja {carne} a comprar");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                subtotal = cantidad * precio;
            }
        }
        else if (categoria == "3")
        {
            Console.WriteLine("1. Zambos");
            Console.WriteLine("2. Doritos");
            Console.WriteLine("3. Ranchitas");
            Console.WriteLine("4. Lays");
            Console.WriteLine("5. Taqueritos");
            string Churros = Console.ReadLine();

            if (Churros == "1")
            {
                Console.WriteLine("1. Normal");
                Console.WriteLine("2. Mediano");
                Console.WriteLine("3. Grande");
                string churros = Console.ReadLine();
                int precio = churros == "1" ? 7 : churros == "2" ? 15 : 32;
                Console.WriteLine($"Ingrese la cantidad de Zambos {churros} a comprar");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                subtotal = cantidad * precio;
            }
        }

        if (Edad >= 65)
        {
            descuento = subtotal * 0.30;
            Console.WriteLine($"Descuento de tercera edad: {descuento:F2}");
        }

        if (categoria == "1" || categoria == "2") 
        {
            double impuestos = subtotal * 0.15;
            Console.WriteLine($"Impuestos: {impuestos:F2}");
            total = subtotal - descuento + impuestos;
        }
        else
        {
            total = subtotal - descuento; 
        }

        Console.WriteLine($"Subtotal: {subtotal:F2}");
        Console.WriteLine($"Total a pagar: {total:F2}");
        Console.ReadKey();
    }
}

