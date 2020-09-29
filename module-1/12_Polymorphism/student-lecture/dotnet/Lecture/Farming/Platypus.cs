using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Platypus : FarmAnimal
    {
        public Platypus () :base("PLATYPUS")
        {

        }
        public void ThumpTail()
        {

        }
        public int SpellingErrorsMade { get; set; } = 1;

        public override string MakeSoundOnce()
        {
            return "grumble";
        }
    }
}
