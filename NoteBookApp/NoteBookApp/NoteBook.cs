using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookApp
{
    class NoteBook
    {
        public const string IntroMessage = "Welcome to DeathNote";
        public const string OuttroMessage = "Good Bye!";

        List<IPageable> pages = new List<IPageable>();

        public delegate void SimpleFunction(string command);
        private Dictionary<string, SimpleFunction> commandLineArgs = new Dictionary<string, SimpleFunction>();
        public readonly string show = "show", _new = "new", delete = "delete";

        public SimpleFunction this[string command]
        {
            get
            {
                return commandLineArgs[command];
            }
        }

        public void Show(string command)
        {
            Console.WriteLine("Show method " + command);
        }
        public void New(string command)
        {
            Console.WriteLine("New method " + command);
        }
        public void Delete(string command)
        {
            Console.WriteLine("Delete method " + command);
        }

        public NoteBook()
        {
            commandLineArgs.Add(show, Show);
            commandLineArgs.Add(_new, New);
            commandLineArgs.Add(delete, Delete);
        }

        public NoteBook(params string[] commandLineKeywords) : this()
        {
            for (int i = 0; i < commandLineKeywords.Length; i++)
            {
                if (commandLineKeywords[i] == "")
                {
                    continue;
                }

                switch (i)
                {
                    case 0:
                        commandLineArgs.Remove(show);
                        commandLineArgs.Add(show = commandLineKeywords[i], Show);
                        break;
                    case 1:
                        commandLineArgs.Remove(_new);
                        commandLineArgs.Add(_new = commandLineKeywords[i], Show);
                        break;
                    case 2:
                        commandLineArgs.Remove(delete);
                        commandLineArgs.Add(delete = commandLineKeywords[i], Show);
                        break;
                }
            }
        }
    }
}
