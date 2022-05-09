using FacebookWinFormsApp_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class MenuItem
    {
        public ICommand Command { get; set; }
        public string Text { get; set; }

        public virtual void Selected()
        {
            if (Command != null)
            {
                Command.Execute();
            }
        }
    }
}
