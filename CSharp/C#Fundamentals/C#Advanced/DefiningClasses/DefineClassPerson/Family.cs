﻿
namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Linq;

    class Family
    {
        private List<Person> people;

        public  List<Person> People
        {
            get => this.people;
            set => this.people = value;
        }

        public Family()
        {
            this.people = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.People.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.People.OrderByDescending(x => x.Age).ToArray()[0];
        }
    }
}
