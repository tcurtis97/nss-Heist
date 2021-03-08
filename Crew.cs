using System;
using System.Collections.Generic;

namespace heist
{
    public class Member
    {
        public string Name { get; set; }
        public int Skill { get; set; }
        public decimal Courage { get; set; }

        public Member(string name, int skill, int courage)
        {
            Name = name;
            Skill = skill;
            Courage = courage;
        }

    }





}