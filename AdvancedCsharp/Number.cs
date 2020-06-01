using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp
{
    public class Number : IEquatable<Number>
    {
        
        public int Value { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            return obj.GetType() == this.GetType() && Equals((Number)obj);
        }

        public bool Equals(Number other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Value == other.Value;
        }
        //public override int GetHashCode()
        //{
        //    return Value.GetHashCode();
        //}

        public override int GetHashCode()
        {
            //unchecked, si una expresión genera un valor que está fuera del intervalo del tipo de destino, no se marca el desbordamiento
            unchecked
            {
                int hashCode = this.Value.GetHashCode();
                return hashCode;
            }
        }
        public static bool operator ==(Number a, Number b)
        {
            bool result = false;
            if (ReferenceEquals(a, b))
            {
                result = true;
            }

            if (ReferenceEquals(a, null))
            {
                result = false;
            }
            if (ReferenceEquals(b, null))
            {
                result = false;
            }

            //result = a.Value == b.Value;
            result = a.Value.Equals(b.Value);
            return result;
        }
        public static bool operator !=(Number a, Number b)
        {
            bool result = false;
            if (a != null && b != null)
            {
                result = !a.Value.Equals(b.Value);
            }
            return result;
        }
    }
}
