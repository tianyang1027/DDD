using System.Collections.Generic;

namespace DomainDrivenDesign
{
    public sealed class FullName : ValueObject
    {
        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public override string ToString() => $"{ FirstName } { LastName }";

        protected override IEnumerable<object> Equals()
        {
            yield return FirstName;
            yield return LastName;
        }
    }
}
