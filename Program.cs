using System;

namespace BooleanLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm küsib kasutajal sisestada kasutajatunnus
            //programm küsib kasutajal sisestada parool
            //programm kontrollib, kas mõlemad, nii kasutajatunnus
            //kui ka parool on õiged
            //kui mõlemad, kasutajatunnus ja parool on õiged
            //programm kuvab konsoolis "Tere tulemast!"
            //kui kasutajatunnus või parool on vale, siis
            //programm kuvab "sisselogimine ebaõnnestus,proovi uuesti."
            //kt:admin, pr:admin1234

            {
                Console.WriteLine("Sisesta kasutajatunnus");
                string UserName = Console.ReadLine();
                Console.WriteLine("Sisesta parool");
                string UserPassword = Console.ReadLine();

                if (UserName == "admin" && UserPassword == "admin1234")
                
                {
                    Console.WriteLine("Tere tulemast");
                } 
                else
                
                {
                    Console.WriteLine("Sisselogimine ebaõnnestus.Proovi uuesti.");
                }

        }
    }
}
