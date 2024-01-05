using System;

namespace InterfaceSegregationPrinciple.Artefatos
{
    class Car : IVehicleCar
    {
        public string  Color { get; set; }
        public int Year { get; set; }
        public double Engine { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }

        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar(color, year, engine, seats, doors);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            Color = color;
            Year = year;
            Engine = engine;
            Seats = seats;
            Doors = doors;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Criando o carro ano {Year}, motor {Engine}, {Seats} assentos {Doors} Portas");
        }

        public void StartVehicle()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Ligando os motores...");
        }
    }
}
