using System;
using System.Collections.Generic;
using System.Linq;

namespace DomainDrivenDesign
{
    public abstract class Base<T> : IEquatable<Base<T>>
    {
        public static bool operator !=(Base<T> a, Base<T> b)
        {
            return !(a == b);
        }

        public static bool operator ==(Base<T> a, Base<T> b)
        {
            if (a is null && b is null)
            {
                return true;
            }

            if (a is null || b is null)
            {
                return false;
            }

            return a.Equals(b);
        }

        public sealed override bool Equals(object obj)
        {
            return Equals(obj as Base<T>);
        }

        public bool Equals(Base<T> obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (GetType() != obj.GetType())
            {
                return false;
            }

            return Equals().SequenceEqual(obj.Equals());
        }

        public override int GetHashCode()
        {
            return Equals().Aggregate(0, (a, b) => (a * 97) + b.GetHashCode());
        }

        protected abstract IEnumerable<object> Equals();
    }
}
