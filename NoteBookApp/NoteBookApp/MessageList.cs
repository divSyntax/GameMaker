using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookApp
{
    class MessageList : TextualMessage
    {
        private enum BulletType { Dashed,Number,Star}
        private BulletType bulletType;

        public override IPageable Input()
        {
            return base.Input();
        }
    }
}
