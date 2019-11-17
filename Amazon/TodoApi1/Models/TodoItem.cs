using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi1.Models
{
    public class TodoItem
    {
        public int id { get; set; }
        public int valutazione { get; set; }
        public int descrizione { get; set; }
        public int timestamp { get; set; }
    }
}
