using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class InfoAttribute:Attribute
    {
        public string Name { get; set; }

        public InfoAttribute()
        { }

        public InfoAttribute(string name)
        {
            Name = name;
        }
    }
}
