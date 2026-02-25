namespace Common.Model
{
    public abstract class ValueObject
    {
        public abstract IEnumerable<object> GetAtomicValues();

        public static bool operator ==(ValueObject one, ValueObject two)
        {
            return one?.Equals(two) ?? false;
        }

        public static bool operator !=(ValueObject one, ValueObject two)
        {
            return !(one?.Equals(two) ?? false);
        }   

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (ValueObject)obj;
            var thisValues = GetAtomicValues().GetEnumerator();
            var otherValues = other.GetAtomicValues().GetEnumerator();

            while (thisValues.MoveNext() && otherValues.MoveNext())
            {
                if (thisValues.Current == null ^ otherValues.Current == null)
                    return false;
                if (thisValues.Current != null && !thisValues.Current.Equals(otherValues.Current))
                    return false;
            }
            return !thisValues.MoveNext() && !otherValues.MoveNext();
        }

    }
}
