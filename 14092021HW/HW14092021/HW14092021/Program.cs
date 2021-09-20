using System;

namespace HW14092021
{
    class Program
    {
        static void Main(string[] args)
        {
            var telephone = new Telephone();

            telephone.Manufacturer = "Samsung";
            telephone.Model = "Galaxy";
            telephone.Length = 12;
            telephone.Width = 9;
            telephone.Depth = 2;

           //==============================================
            var mashina = new Mashina();
            mashina.Marka = "VW";
            mashina.Numurs = "PT1978";
            mashina.Atrums = 8;

            string uztaure = mashina.Uztaure();
            Console.WriteLine(uztaure);

            //============================================


            var prece = new Prece();

            Console.WriteLine($"Ievadiet preces augstumu");
            string Augstums = Console.ReadLine();
            double Augstums1 = double.Parse(Augstums);

            Console.WriteLine($"Preces garums");
            string Garums = Console.ReadLine();
            double Garums1 = double.Parse(Garums);
            
            Console.WriteLine($"Preces svars");
            string Svars = Console.ReadLine();
            double Svars1 = int.Parse(Svars);


            prece.Augstums = Augstums1;
            prece.Garums = Garums1;
            prece.Svars = Svars1;

            string precesparametri = prece.PrecesParametri();
            Console.WriteLine(precesparametri);


            //============================================



















        }
    }
}
