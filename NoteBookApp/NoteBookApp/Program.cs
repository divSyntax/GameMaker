using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NoteBook note = new NoteBook("see","create", "remove");
            const string ExitProgramKeyword = "exit";
            string commandPrompt = "Please enter " + note.show + "," + note.delete + ", or " + note._new;
            Console.WriteLine(NoteBook.IntroMessage);
            string input = "";


            do
            {
                input = Console.ReadLine();
                string[] command = input.Split();
                try
                {
                    note[command[0]]((command.Length > 1) ? command[1] : "");
                }catch(KeyNotFoundException e)
                {
                    Console.WriteLine(commandPrompt);
                }
            } while (input != ExitProgramKeyword);

            Console.WriteLine(NoteBook.OuttroMessage);
        }
    }
}
