using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookApp
{
    public struct PageData //holds user data
    {
        public string title;
        public string author;


    }
    public interface IPageable
    {
        PageData MyData { get; set; }
        IPageable Input();

        void Output();
    }
}
