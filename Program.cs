﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            int skill = 0;

            decimal courage = 0;


            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("Make your team");
            Console.WriteLine("Add a name >");
            name = Console.ReadLine();

            Console.WriteLine("Add a skill level (number) >");
            skill = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{skill}");

            Console.WriteLine("Add a Courage level (number) >");
            courage = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{courage}");

            Member crewMember = new Member(name, skill, courage);

            crewMember.AddMember(crewMember);
        }












    }
}
