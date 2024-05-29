namespace BuilderPerson
{
    public class PersonAddressBuilder : CompositePersonBuilder
    {
        //private Person person;
        
        public PersonAddressBuilder(Person person) //: base(person)
        {
            this.person = person;
        }
        public PersonAddressBuilder At(string streetAddress)
        {
            person.StreetAddress = streetAddress;
            return this;
        }
        public PersonAddressBuilder WithPostcode(string postcode)
        {
            person.Postcode = postcode;
            return this;
        }

        public PersonAddressBuilder In(string city)
        {
            person.City = city;
            return this;
        }


    }
}