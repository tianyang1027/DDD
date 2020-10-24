using System;
using System.Collections.Generic;

namespace DomainDrivenDesign
{
    public abstract class Entity : Base<Entity>
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        protected sealed override IEnumerable<object> Equals()
        {
            yield return Id;
        }
    }
}
