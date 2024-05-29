namespace BuilderPerson
{
    public class PersonJobBuilder : CompositePersonBuilder   
    {
        //private Person person;

        public PersonJobBuilder(Person person) //: base(person)
        {
            this.person = person;
        }

        public PersonJobBuilder At(string companyName)
        {
            person.CompanyName = companyName;
            return this;
        }
        public PersonJobBuilder AsA(string position)
        {
            person.Position = position;
            return this;
        }

        public PersonJobBuilder Earning(int anualIncome)
        {
            person.AnnualIncome = anualIncome;
            return this;
        }
    }
}