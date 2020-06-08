using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Logic;

namespace IOnieRekrutacja
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMainScreen();
            Console.ReadKey();
        }

        private static void GetKeyFromUser(char input)
        {
            var logic = new ItemLogic();
            Console.WriteLine($"Chosen option: {input}");

            switch (input)
            {
                case 'Q':
                    Console.WriteLine("Bye");
                    Environment.Exit(0); 
                    break;
                case 'q':
                    goto case 'Q';
                case '1':
                    logic.AddNewItem();
                    break;
                case '2':
                    logic.UpdateLastItem();
                    break;
                case '3':
                    logic.DeleteLastItem();
                    break;
                default:
                    DisplayMainScreen();
                    break;
            }
        }

        private static void DisplayMainScreen()
        {
            Console.WriteLine("-------- Wciśnij klawisz --------" +
                "\n\nQ - zamknięcie programu" +
                "\n1 – add nowego obiektu encji" +
                "\n2 – aktualizacja obiektu encji" +
                "\n3 – usunięcie obiektu encji z bazy");
            char input = Console.ReadKey().KeyChar;
            GetKeyFromUser(input);
        }
    }
}
