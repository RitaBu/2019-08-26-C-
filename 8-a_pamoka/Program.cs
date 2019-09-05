using System;

namespace AstuntaPamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            PasisveikinkDaugKartu(); //1.
            NuskaitykIrSudaugink(); //2.
            NuskaitykIrPalygink(); //3.

            //4.
            PakelkKvadratu(2);
            PakelkKvadratu(-4);

            //5.
            PaverskIZodi(6);
            PaverskIZodi(11);

            //6.
            PaskaiciuokStaciakampioPlota(10, 2);
            PaskaiciuokStaciakampioPlota(19, 10);

            //7.
            PaskaiciuokStTrikampioPlota(5, 8);

            //8. 
            IsveskFaktoriala(10);
            IsveskFaktoriala(0);

            //9.
            AtspausdinkNuo1ikiX(10);
            AtspausdinkNuo1ikiX(100);

            //10. 
            PaskaiciuokApskritimoPlota(5);

            //11.
            IsveskDaugybosLentele(2);
            IsveskDaugybosLentele(9);

            //12.
            Pasisveikink();
            Pasisveikink("Kuku");

            //13.
            int[] skaiciai = { 5, 4, 4, 5, 6, 5, 0, 0, 5, 0 };
            PaskaiciuokSuma(skaiciai);

            int[] pazymiai = { 10, 7, 9, 10, 5, 8, 10 };
            PaskaiciuokSuma(skaiciai);

            //14.
            int rez = GrazinkKvadrata(5);
            Console.WriteLine(rez);

            Console.WriteLine(GrazinkKvadrata(-2));

            //15.
            string t = Suklijuok("Labas", ", as krabas");
            Console.WriteLine(t);

            Console.WriteLine(Suklijuok("vienas ", "du"));

            //16.
            int suma = GrazinkSuma(2, 2);
            Console.WriteLine(suma);

            Console.WriteLine(GrazinkSuma(4, 5));

            //17.
            double rezultatas = PadalinkIs10(9);
            Console.WriteLine(rezultatas);

            Console.WriteLine(PadalinkIs10(5));

            //18.
            bool arLyginis = ArLyginis(10);
            Console.WriteLine(arLyginis);

            Console.WriteLine(ArLyginis(7));

            //19.
            int min = Min(skaiciai); //skaiciu masyvas deklaruotas virsuje
            Console.WriteLine(min);

            //20.
            Console.WriteLine(Max(pazymiai)); //pazymiu masyvas deklaruotas virsuje

            //21. ir 22.
            PatikrinkFizineBukle(106.5, 1.92);
        }

        //1. Sukurkite metodą, kuris 10 kartų į komandinį langą išveda žodį “Labas”
        public static void PasisveikinkDaugKartu()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Labas");
            }
        }

        //2. Sukurkite metodą, kuris konsolėje paprašo įvesti du skaičius, juos nuskaito ir į konsolę išveda jų sandaugą.
        public static void NuskaitykIrSudaugink()
        {
            Console.WriteLine("Iveskite pirma skaiciu:");
            int sk1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite antra skaiciu:");
            int sk2 = int.Parse(Console.ReadLine());

            Console.WriteLine(sk1 * sk2);
        }

        //3. Sukurkite metodą, kuris konsolėje paprašo įvesti du skaičius ir išveda didžiausią. Jei skaičiai abu lygūs, tuomet išveda, kad abu skaičiai yra lygūs.
        public static void NuskaitykIrPalygink()
        {
            Console.WriteLine("Iveskite pirma skaiciu:");
            int sk1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite antra skaiciu:");
            int sk2 = int.Parse(Console.ReadLine());

            if (sk1 > sk2)
            {
                Console.WriteLine("Didziausias: " + sk1);
            }
            else if (sk2 > sk1)
            {
                Console.WriteLine("Didziausias: " + sk2);
            }
            else
            {
                Console.WriteLine("Skaiciai yra lygus");
            }
        }

        //4. Sukurkite metodą, kuris kaip parametrą priima vieną sveiką skaičių ir išveda jo kvadratą.
        public static void PakelkKvadratu(int sk)
        {
            Console.WriteLine(sk * sk);
        }

        //5. Sukurkite metodą, kuris kaip parametrą priima vieną sveiką skaičių ir išveda jo žodinį pavadinimą (jei 1, tai išveda “vienas”, jei 2 - “du” ir t.t. jei daugiau už 10 - “daug”)
        public static void PaverskIZodi(int sk)
        {
            switch (sk)
            {
                case 1:
                    Console.WriteLine("vienas");
                    break;
                case 2:
                    Console.WriteLine("du");
                    break;
                case 3:
                    Console.WriteLine("trys");
                    break;
                case 4:
                    Console.WriteLine("keturi");
                    break;
                case 5:
                    Console.WriteLine("penki");
                    break;
                case 6:
                    Console.WriteLine("sesi");
                    break;
                case 7:
                    Console.WriteLine("septyni");
                    break;
                case 8:
                    Console.WriteLine("astuoni");
                    break;
                case 9:
                    Console.WriteLine("devyni");
                    break;
                case 10:
                    Console.WriteLine("desimt");
                    break;
                default:
                    Console.WriteLine("Daug!");
                    break;
            }
        }

        //6. Sukurkite metodą, kuris kaip parametrą priima du sveikus skaičius - stačiakampio kraštinių ilgius ir išveda stačiakampio plotą 
        public static void PaskaiciuokStaciakampioPlota(int a, int b)
        {
            Console.WriteLine("Staciakampio plotas: " + a * b);
        }

        //7. Sukurkite metodą, kuris kaip parametrus priima du sveikus skaičius (statinių ilgius) ir išveda apskaičiuotą stataus trikampio plotą
        public static void PaskaiciuokStTrikampioPlota(int a, int b)
        {
            Console.WriteLine("Stataus trikampio plotas: " + a * b / 2);
        }

        //8. Sukurkite metodą, kuris kaip parametrą priima vieną sveiką skaičių ir išveda jo faktorialą
        public static void IsveskFaktoriala(int sk)
        {
            int faktorialas = 1;

            for (int i = 1; i <= faktorialas; i++)
            {
                faktorialas = faktorialas * i;
            }

            Console.WriteLine(sk + "! = " + faktorialas);
        }

        //9. Sukurkite metodą, kuris kaip parametrą priima vieną sveiką skaičių x ir išveda visus skaičius nuo 1 iki x.
        public static void AtspausdinkNuo1ikiX(int sk)
        {
            for (int i = 1; i <= sk; i++)
            {
                Console.WriteLine(i);
            }
        }

        //10. Sukurkite metodą, kuris kaip parametrą priima vieną double tipo skaičių r - apskritimo spindulį ir išveda paskaičiuotą apskritimo plotą (pi * r * r)
        public static void PaskaiciuokApskritimoPlota(double r)
        {
            Console.WriteLine("Apskritimo plotas: " + Math.PI * r * r);
        }

        //11. Sukurkite metodą, kuris priima vieną skaičių ir išveda jo daugybos lentelę
        public static void IsveskDaugybosLentele(int sk)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "*" + sk + "=" + i*sk);
            }
        }

        //12. Sukurkite metodą, kuris kaip parametrą priima pasisveikinimo tekstą (string) ir jį išvedą į Console langą. Jei pasisveikinimo teksto kviečiant metodą neperduodą, tuomet jis turi būti lygus reikšmei “Labas”.
        public static void Pasisveikink(string tekstas = "Labas")
        {
            Console.WriteLine(tekstas);
        }

        //13. Sukurkite metodą, kuris kaip parametrą priima skaičių masyvą ir išveda paskaičiuota skaičių sumą.
        public static void PaskaiciuokSuma(int[] masyvas)
        {
            int suma = 0;
            for (int i = 0; i < masyvas.Length; i++)
            {
                suma = suma + masyvas[i];
            }
            Console.WriteLine("Masyvo skaiciu suma: " + suma);
        }

        //14. Sukurkite metodą, kuris kaip parametrą priima vieną sveiką skaičių ir grąžina jo kvadratą
        public static int GrazinkKvadrata(int sk)
        {
            return sk*sk;
        }

        //15. Sukurkite metodą, kuris priima du string parametrus, juos sujungia į vieną ir grąžiną vieną bendrą tekstą(string)
        public static string Suklijuok(string t1, string t2)
        {
            return t1 + t2;
        }

        //16. Sukurkite metodą, kuris priima du sveikus skaičius ir grąžina jų sumą
        public static int GrazinkSuma(int sk1, int sk2)
        {
            return sk1 + sk2;
        }

        //17.Sukurkite metodą, kuris priima double skaičių ir grąžina jį padalintą iš 10.
        public static double PadalinkIs10(double sk)
        {
            return sk / 10;
        }

        //18. Sukurkite metodą, kuris kaip parametrą priima vieną sveiką skaičių ir grąžina, ar jis yra lyginis (true/false).
        public static bool ArLyginis(int sk)
        {
            return sk % 2 == 0;
        }

        //19. Parašykite metodą Min, kuris priima skaičių masyvą ir grąžiną mažiausią skaičių. (reikės naudoti for ciklą ir sąlygas, bet ne Math biblioteką!)
        public static int Min(int[] m)
        {
            int min = m[0];

            for (int i = 0; i < m.Length; i++)
            {
                if(m[i] < min)
                {
                    min = m[i];
                }
            }

            return min;
        }

        //20. Parašykite metodą Max, kuris priima skaičių masyvą ir grąžiną didžiausią skaičių. (reikės naudoti for ciklą ir sąlygas, bet ne Math biblioteką!)
        public static int Max(int[] m)
        {
            int max = m[0];

            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] > max)
                {
                    max = m[i];
                }
            }

            return max;
        }

        //21. Sukurkite metodą, kuris suskaičiuoja žmogaus kūno masės indeksą ir grąžina rezultatą. Priima du parametrus - svorį ir ūgį. 
        //Formulė: svoris kg / (ūgis metrais) ^ 2).
        public static double Kmi(double svoris, double ugis)
        {
            return svoris / (ugis * ugis);
        }

        //22. Papildyti pirmo pratimo programą parašant metodą, kuris pagal gautą KMI nustato žmogaus fizinę būseną(Šis metodas savyje turi iškviesti KMI skaičiuojantį metodą)
        public static void PatikrinkFizineBukle(double svoris, double ugis)
        {
            var kmi = Kmi(svoris, ugis);

            if(kmi < 15)
            {
                Console.WriteLine("Badaujantis žmogus.");
            }
            else if (kmi < 18.5)
            {
                Console.WriteLine("Liesas žmogus.");
            }
            else if (kmi < 25)
            {
                Console.WriteLine("Normalaus svorio žmogus.");
            }
            else if (kmi < 30)
            {
                Console.WriteLine("Turintis viršsvorio žmogus.");
            }
            else if (kmi < 40)
            {
                Console.WriteLine("Nutukęs žmogus.");
            }
            else
            {
                Console.WriteLine("Ligotai nutukęs žmogus.");
            }
        }
    }
}
