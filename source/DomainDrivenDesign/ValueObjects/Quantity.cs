namespace DomainDrivenDesign
{
    public sealed class Quantity : ValueObject<decimal>
    {
        public Quantity(decimal value) : base(value) { }

        public override string ToString() => Value.ToString();
    }
}
