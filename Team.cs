using System;
using System.Collections.Generic;

namespace heist
{
    public class Teammate
    {
        public string Name { get; set; }
        public int Skill { get; set; }
        public decimal Courage { get; set; }

        public Teammate(string name, int skill, int courage)
        {
            Name = name;
            Skill = skill;
            Courage = courage;
        }

    }





}