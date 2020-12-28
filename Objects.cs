using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard
{
    class Pack
    {
        public int length { get; set; }
        public Card[] cards { get; set; }
    }
    class Card
    {
        public string frontCard { get; set; }
        public string backCard { get; set; }
        public bool isQuestion { get; set; }
    }
}
