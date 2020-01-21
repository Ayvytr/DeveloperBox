using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperBox
{
    class Translate
    {
        public List<Sentences> sentences { get; set; }
        public string src { get; set; }
    }

    public class Sentences
    {
        public string trans { get; set; }
        public string orig { get; set; }
        public string backend { get; set; }
    }
}
