using System;
using System.Collections.Generic;

namespace heist
{
    public class Crew
    {
        public List<Member> crewList = new List<Member>();
        public void AddMember(Member member)
        {
            crewList.Add(member);
        }
    }





}