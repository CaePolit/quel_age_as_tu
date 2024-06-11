using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Quel age as-tu? ");
        string entry = Console.ReadLine();
        int age = default;
        bool sucess = false;
        while (!(sucess))
        {
            sucess = int.TryParse(entry, out age);
            if (!(sucess))
            {
                Console.Write("S'il te plait, mets ton age en chiffre entier positive: ");
                entry = Console.ReadLine();
            }
        }
        
        if (age < 18)
        {
            Console.WriteLine("Vous etes mineur");
        }
        else if (age >= 18 && age < 25)
        {
            Console.WriteLine("Vous etes majeur");
        }
        else if (age >= 25 && age < 30)
        {
            Console.WriteLine("Vous etes en chemin adulte");
        }
        else if (age >= 30 && age < 70)
        {
            Console.WriteLine("Vous etes adulte");
        }
        else
        {
            Console.WriteLine("vous etes en beton armé !");
        }

    }
}