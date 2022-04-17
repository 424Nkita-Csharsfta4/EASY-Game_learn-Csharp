using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Learn_Ccharp
{
    class MenuItem
    {

      

        public int ID { get; set; }
        public string Text { get; set; }
        public Action Action { get; set; }

        
        public MenuItem()
        {

        }

        public MenuItem(int id, string text, Action action)
        {
            this.ID = id;
            this.Text = text;
            this.Action = action;
        }

        
    }
}
