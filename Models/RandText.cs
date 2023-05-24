using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class RandText
    {
        public RandText()
        {            
        }
        public RandText(string text, string janr) 
        { 
            this.Text = text;
            this.Janr = janr;
        }


        public string Text;
        public string Janr;
    }
}
