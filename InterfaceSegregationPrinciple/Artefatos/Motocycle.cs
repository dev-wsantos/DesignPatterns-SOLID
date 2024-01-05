using System;

namespace InterfaceSegregationPrinciple.Artefatos
{
    class Motocycle : IVehicleMotocycle
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public double Engine { get; set; }

        public Motocycle(string color, int year, double engine)
        {
            ConfigureMotocycle(color, year, engine);
        }

        public void ConfigureMotocycle(string color, int year, double engine)
        {
            Color = color;
            Year = year;
            Engine = engine;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Criando a moto ano {Year}, {Engine} cilindradas e da cor {Color}");
        }

        public void StartVehicle()
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ligando os motores...");
        }
    }
}
