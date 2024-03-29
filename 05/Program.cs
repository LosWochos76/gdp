﻿namespace Vorlesung
{
    public class Program
    {
        public static void Uhrzeit()
        {
            int now_hour = 16;
            int now_minute = 40;
            int add_minutes = 1784;

            int then = now_hour * 60 + now_minute + add_minutes;
            int then_hour = (then / 60) % 24;
            int then_minute = then % 60;

            Console.WriteLine("Es ist {0}:{1} Uhr", then_hour, then_minute);
        }

        public static void Summe3oder5Teilbar()
        {
            int z = 1;
            int summe = 0;

            while (z <= 100)
            {
                summe += z;
                z++;
            }

            Console.WriteLine("Summe={0}", summe);
        }

        public static void Zinseszins()
        {
            double monatlicher_zins = 1.5;
            double monatliche_sparrate = 100;
            double guthaben = 0;

            int monate = 24;
            int i = 0;

            // Die Laufbedingung kann so geändert werden, dass sie sich nicht auf die Monate, sondern auf das Guthaben bezieht:
            while (i <= monate)
            {
                guthaben += monatliche_sparrate + (guthaben / 100 * monatlicher_zins);
                i++;

                Console.WriteLine("Guthaben nach {0} Monaten: {1:C}", i, guthaben);
            }
        }

        public static void ZahlEinlesen()
        {
            int zahl = 0;
            bool zahl_durch_3_oder_5_teilbar = false;

            do
            {
                Console.Write("Bitte Zahl eingeben: ");
                zahl = Convert.ToInt32(Console.ReadLine());
                zahl_durch_3_oder_5_teilbar = zahl % 3 == 0 || zahl % 5 == 0;
            }
            while (!zahl_durch_3_oder_5_teilbar);
        }

        public static void Kleines1mal1()
        {
            Console.Clear();

            int i = 1;
            while (i <= 10)
            {
                int j = 1;
                while (j <= 10)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                    j++;
                }

                i++;
            }
        }

        public static void Tannenbaum()
        {
            int hoehe = 5;

            int zeile = 0;
            while (zeile < hoehe)
            {
                int leerzeichen = 0;
                while (leerzeichen < hoehe - zeile - 1)
                {
                    Console.Write(" ");
                    leerzeichen++;
                }

                int sterne = 0;
                while (sterne < zeile * 2 + 1)
                {
                    Console.Write("*");
                    sterne++;
                }

                Console.WriteLine();
                zeile++;
            }

            int l = 0;
            while (l < hoehe - 1)
            {
                Console.Write(" ");
                l++;
            }
            Console.WriteLine("*");
        }

        public static void BreakAndContinue() 
        {
            int i = 0;
            while (true) 
            {
                i++;

                if (i % 2 != 0)
                    continue;

                if (i > 100)
                    break;

                Console.WriteLine(i);
            }
        }

        public static void Main(string[] args)
        {
            // Kommentarzeichen löschen, um den jeweiligen Code auszuprobieren:
            //Uhrzeit();
            //Summe3oder5Teilbar();
            //Zinseszins();
            //ZahlEinlesen();
            //Kleines1mal1();
            //Tannenbaum();
            BreakAndContinue();
        }
    }
}