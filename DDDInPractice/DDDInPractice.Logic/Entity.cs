using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDInPractice.Logic
{
    /// <summary>
    /// Use the abstract modifier in a class declaration 
    /// to indicate that a class is intended only to be a base class of other classes
    /// </summary>
    public abstract class Entity
    {
        public long Id { get; private set; }
        public override bool Equals(object obj)
        {
            var other = obj as Entity;
            if (ReferenceEquals(other, null)) return false;
            if (ReferenceEquals(other, obj)) return true;
            if (GetType() != other.GetType()) return false;
            if (Id == 0 || other.Id == 0) return false;

            return other.Id == Id;
         }

        public override int GetHashCode()
        {
            return (GetType().ToString() + Id).GetHashCode();
        }

        public static bool operator ==(Entity a,Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }
    }
}
