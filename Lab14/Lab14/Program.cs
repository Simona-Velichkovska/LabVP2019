using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        // Funkcija za generiranje sluchajna lozinka 
        // PasswordStrenght e tip enumeracija (easy, normal , hard) 
        enum PasswordStrenght: byte
        {
            easy = 1,
            normal =2,
            hard =3
        }
        static string generatePassword(PasswordStrenght passwordStrenght){
            // easy lozinkata treba da ima do 6 znaci (samo mali bukvi)
            // normal lozinkata treba da ima od 6 do 10 znaci (da sodrzhi golemi bukvi i 
            // brojki 
            // hard loznikata treba da ima povekje od 10 znaci i da sodrzhi mali, golemi 
            // bukvi i specijalni znaci 
            Random random = new Random();

            //Za easy lozinka
            string easyLozinka="";

            //Za normal Lozinka
            int normalLength;
            normalLength = random.Next(6, 10);
            string normalLozinka = "";
            //za hard lozinka
            int hardLength;
            hardLength = random.Next(10, 30);
            string hardLozinka = "";


            for (int i = 0; i < 6; i++) {
                easyLozinka += Convert.ToChar(random.Next(97, 122));
            }

          
            for(int i=0; i < normalLength; i++)
            {
                if (random.Next(1, normalLength) == i)
                {
                    normalLozinka += Convert.ToChar(random.Next(48, 57));
                }
                else
                {

                    normalLozinka += Convert.ToChar(random.Next(65, 90));
                }
            }
            for (int i = 0; i < hardLength; i++)
            {
                hardLozinka += Convert.ToChar(random.Next(33, 123));
            }



            if (passwordStrenght == PasswordStrenght.easy)
            {

                    return easyLozinka;
            }
            else if(passwordStrenght == PasswordStrenght.normal)
            {

                    return normalLozinka;
            }
             else if (passwordStrenght == PasswordStrenght.hard)
            {

                    return hardLozinka;
               
            }

                return "";
            
        }
        static void Main(string[] args)
        {
            char[] delimiter = { ' ' };
            string[] parts = new string[3];

            PasswordStrenght easyPass = PasswordStrenght.easy;
            PasswordStrenght normalPass = PasswordStrenght.normal;
            PasswordStrenght hardPass = PasswordStrenght.hard;

            string pogodi;
            
            string generatedPasswordEasy = generatePassword(easyPass);
            string generatedPasswordNormal = generatePassword(normalPass);
            string generatedPasswordHard = generatePassword(hardPass);
            //To try out if guessing them right works uncomment this line.
            // Console.WriteLine("{0}  {1}  {2}", generatedPasswordEasy, generatedPasswordHard, generatedPasswordNormal);

            
            Console.WriteLine("Guess a hard password an easy one and a normal one. Separate your guesses with a space");
            pogodi=Convert.ToString(Console.ReadLine());

            parts = pogodi.Split(delimiter);

            int guessedRight = 0;

            foreach(string character in parts)
            {
                if(generatedPasswordEasy.CompareTo(character)==0)
                {
                    guessedRight = 1;
                    Console.WriteLine("You've guessed the easy passowrd right. And it was:{0}{1}  ",Environment.NewLine, generatedPasswordEasy);
                }
                if (generatedPasswordNormal.CompareTo(character) == 0)
                {
                    guessedRight = 1;
                    Console.WriteLine("You've guessed the normal passowrd right. And it was:{0}{1}  ", Environment.NewLine, generatedPasswordNormal);
                }
                if (generatedPasswordHard.CompareTo(character) == 0)
                {
                    guessedRight = 1;
                    Console.WriteLine("You've guessed the hard passowrd right. And it was:{0}{1}  ", Environment.NewLine, generatedPasswordHard);
                }

            }

            if (guessedRight == 0)
            {
                Console.WriteLine("You haven't guessed any password right");
            }

            Console.ReadKey();
        }
    }
}
