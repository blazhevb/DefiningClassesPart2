using System.Text;

namespace DefiningClassesPart2
{
    class GenericListTemp<T>
        where T : System.IComparable
    {
        private T[] array;

        public GenericListTemp()
        {
            array = new T[4];
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public void Add(T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (this[i].Equals(default(T)))
                {
                    this[i] = element;
                    return;
                }
                if (i == array.Length - 1)
                {
                    Extend();
                }
            }
        }
        public void Add(T element, int index)
        {
            if (index < array.Length)
            {
                if (this[index].Equals(default(T)))
                {
                    this[index] = element;
                }
                else
                {
                    T temp1 = this[index];
                    T temp2;
                    for (int i = index; i < array.Length; i++)
                    {
                        if (i == array.Length - 1)
                        {
                            Extend();
                        }

                        if (!this[i + 1].Equals(default(T)))
                        {
                            temp2 = this[i + 1];
                            this[i + 1] = temp1;
                            temp1 = temp2;
                        }
                        else
                        {
                            this[i + 1] = temp1;
                            break;
                        }

                    }
                    this[index] = element;
                }
            }
        }
        public T GetElement(int index)
        {
            T result = this[index];
            return result;
        }
        public void Remove(int index)
        {
            if (index < array.Length)
            {
                if (!this[index].Equals(default(T)))
                {
                    this[index] = default(T);
                    for (int i = index; i < array.Length - 1; i++)
                    {
                        this[i] = this[i + 1];
                        this[i + 1] = default(T);
                    }
                }
            }
        }
        public void Clear()
        {
            array = null;
            array = new T[4];
        }
        public int Find(T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (this[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                if (!this[i].Equals(default(T)))
                {
                    sb.Append(this[i] + " ");
                }

            }
            return sb.ToString();
        }
        public int Capacity()
        {
            return array.Length;
        }
        private int CountAvailable(int start)
        {
            int counter = 0;
            for (int i = start; i < array.Length; i++)
            {
                if (!this[i].Equals(default(T)))
                {
                    counter++;
                }
            }
            return counter;
        }
        private void Extend()
        {
            int size = array.Length * 2;
            T[] buffer = new T[size];
            for (int i = 0; i < array.Length; i++)
            {
                buffer[i] = this[i];
            }
            array = null;
            array = buffer;
        }
        public T Min()
        {
            T minimum = this[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (!(this[i].Equals(default(T))) && (minimum.CompareTo(this[i]) > 0))
                {
                    minimum = this[i];
                }
            }
            return minimum;
        }
        public T Max()
        {
            T maximum = this[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (!(this[i].Equals(default(T))) && (maximum.CompareTo(this[i]) < 0))
                {
                    maximum = this[i];
                }
            }
            return maximum;
        }
    }
}