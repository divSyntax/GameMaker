using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookApp
{
    class TextualMessage : IPageable
    {
        protected PageData myData;
        protected string message;
        public PageData MyData
        {
            get
            {
                return myData;
            }

            set
            {
                myData = value;
            }
        }

        public virtual IPageable Input()
        {
            throw new NotImplementedException();
        }

        public void Output()
        {
            throw new NotImplementedException();
        }
    }
}
