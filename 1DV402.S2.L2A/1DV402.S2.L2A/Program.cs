using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L2A
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variabler
            string horizontalLine;

           

            //test1
            AlarmClock alarm = new AlarmClock();
            ViewTestHeader("Test 1. \n Test av standardkonstruktorn. \n" );
            Console.WriteLine(alarm);

            //test2
            alarm = new AlarmClock(9, 42);
            ViewTestHeader("test 2. \n Test av med 2 parametrar, \n");
            Console.WriteLine(alarm);

            //test3
           alarm = new AlarmClock(13, 24, 7, 35);
           ViewTestHeader("Test 3. \n Test av konstruktor med 4 parametrar \n");
           Console.WriteLine(alarm);

           //test4
           alarm.Hour = 23;
           alarm.Minute = 58;
           ViewTestHeader("Test 4. \n Ställer befintiligt AlarmClock-objekt till 23.58 och låter den gå 13 minuter. \n");
           Run(alarm, 13);

           //test5
           alarm.Hour = 6;
           alarm.Minute = 12;
           alarm.AlarmHour = 6;
           alarm.AlarmMinute = 15;
           ViewTestHeader("Test 5. \n Ställer ett befintligt AlarmClock-objekt till tiden 6:12 och alarmtiden 6:15 och låter den gå 6 minuter. \n");
           Run(alarm, 6);

           //test6
           ViewTestHeader("Test 6. \n Testar egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden \n");
           

           try
            {
                alarm.Hour = 24;
                alarm.ToString();
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
               alarm.Minute = 60;
                alarm.ToString();
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
                alarm.AlarmHour = 24;
                alarm.ToString();
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
                alarm.AlarmMinute = 60;
                alarm.ToString();
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            //test 7
            ViewTestHeader("Test 7. \n Testar konstruktorerna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden. \n");

            try
            {
                alarm = new AlarmClock(24, 60);
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }

            try
            {
                alarm = new AlarmClock(24, 60, 24, 60);
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
           
            
        }

        private static void Run(AlarmClock ac, int minutes)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("        Väckarklockan URLED <TM>       ");
            Console.WriteLine("        Modellnr.: 1DV402S2L2A         ");
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();

            for (int i = 0; i < minutes; i++)
            {
                if (ac.TickTock())
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(ac.ToString() + "    BEEP! BEEP! BEEP!");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(ac.ToString());
                }         
            }
        }

        private static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ViewTestHeader(string header)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(header);
        }
    }
}
