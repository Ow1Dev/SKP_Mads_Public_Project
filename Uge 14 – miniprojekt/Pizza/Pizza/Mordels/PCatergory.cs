using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Mordel
{
    public class PCatergory
    {
        public string Name { get; set; }
        public List<PMenu> Items { get; set; } = new List<PMenu>();

        public override string ToString()
        {
            return Name;
        }
    }
}
