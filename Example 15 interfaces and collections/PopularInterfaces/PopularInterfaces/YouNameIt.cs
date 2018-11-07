using System;
using System.Collections.Generic;

namespace PopularInterfaces
{
    class YouNameIt<T> : IComparable, ICloneable, IEnumerable<T>, IDisposable, IList<T>, ICollection<T>
    {
        public int YouNameItVersion { get; private set; }
        public T[] Readings { get; set; }

        public YouNameIt(T[] inReadings)
        {
            YouNameItVersion = 1;
            Readings = inReadings;
        }

        public YouNameIt()
        {
            Readings = new T[0];
        }

        #region IComparable
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            YouNameIt<T> otherArray = (YouNameIt<T>)obj;
            int res = 0;
            // We could use this, but we have enumerator
            //for (int i = 0; i < otherArray.Readings.Length && i < Readings.Length; i++)
            //{
            //    T thisReading = Readings[i];
            //    T otherReading = otherArray.Readings[i];
            //    res += ((IComparable)thisReading).CompareTo((IComparable)otherReading);
            //}

            IEnumerator<T> thisEnumerator = this.GetEnumerator();
            IEnumerator<T> otherEnumerator = otherArray.GetEnumerator();
            while (otherEnumerator.MoveNext() && thisEnumerator.MoveNext())
            {
                T thisReading = thisEnumerator.Current;
                T otherReading = otherEnumerator.Current;
                res += ((IComparable)thisReading).CompareTo((IComparable)otherReading);
            }

            if (res < 0) res = -1;
            if (res > 0) res = 1;
            return res;

        }
        #endregion

        #region ICloneable
        public object Clone()
        {
            return new YouNameIt<T>(Readings) { YouNameItVersion = this.YouNameItVersion + 1 };
        }
        #endregion

        #region IEnumerable
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Readings.Length; i++)
            {
                yield return Readings[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Readings.Length; i++)
            {
                yield return Readings[i];
            }
        }
        #endregion

        #region IDisposable
        public void Dispose()
        {
            // If we had a file locked
            // This is where we must ensure to release it
        }
        #endregion

        #region IList
        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            T[] readings = new T[Readings.Length + 1];
            Readings.CopyTo(readings, 0);
            readings[readings.Length - 1] = item;
            Readings = readings;
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            T[] readings = new T[Readings.Length + 1];
            Readings.CopyTo(readings, 0);
            readings[readings.Length - 1] = item;
            Readings = readings;
        }

        public void Clear()
        {
            Readings = new T[0];
        }

        public bool Contains(T item)
        {
            foreach (T reading in Readings)
            {
                if (item.Equals(reading))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return Readings.Length; }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }
        #endregion



        //void ICollection<T>.Add(T item)
        //{
        //    throw new NotImplementedException();
        //}

        //void ICollection<T>.Clear()
        //{
        //    throw new NotImplementedException();
        //}

        //bool ICollection<T>.Contains(T item)
        //{
        //    throw new NotImplementedException();
        //}

        //void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        //{
        //    throw new NotImplementedException();
        //}

        //int ICollection<T>.Count
        //{
        //    get { throw new NotImplementedException(); }
        //}

        //bool ICollection<T>.IsReadOnly
        //{
        //    get { throw new NotImplementedException(); }
        //}

        //bool ICollection<T>.Remove(T item)
        //{
        //    throw new NotImplementedException();
        //}



    }
}
