using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPerson
{
    public class CompositePersonBuilder
    {
        protected Person person; // this is a reference!
        public CompositePersonBuilder() => person = new Person();
        //protected PersonBuilder(Person person) => this.person = person;
        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);
        public PersonJobBuilder Works => new PersonJobBuilder(person);


        public static implicit operator Person(CompositePersonBuilder pb)
        {
            return pb.person;
        }
    }
}
