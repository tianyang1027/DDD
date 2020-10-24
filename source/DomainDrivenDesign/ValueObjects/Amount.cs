namespace DomainDrivenDesign
{
    public sealed class Amount : ValueObject<decimal>
    {
        public Amount(decimal value) : base(value) { }

        public override string ToString() => Value.ToString();
    }
}
