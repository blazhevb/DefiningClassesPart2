using System.Text;

namespace DefiningClassesPart2
{
    class GenericList<T>
        where T : System.IComparable
    {
        private T[] array;

        public GenericList()
        {
            array = new T[4];
        }



        public void Add(T element)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i].Equals(default(T)))
                {
                    array[i] = element;
                    return;
                }
                if(i == array.Length - 1)
                {
                    Extend();
                }
            }
        }
        public void Add(T element, int index)
        {
            if(index < array.Length)
            {
                if (array[index].Equals(default(T)))
                {
                    array[index] = element;
                }
                else
                {
                    T temp1 = array[index];
                    T temp2;
                    for (int i = index; i < array.Length; i++)
                    {
                        if(i == array.Length - 1)
                        {
                            Extend();
                        }

                        if (!array[i + 1].Equals(default(T)))
                        {
                            temp2 = array[i + 1];
                            array[i + 1] = temp1;
                            temp1 = temp2;
                        }
                        else
                        {
                            array[i + 1] = temp1;
                            break;
                        }
                        
                    }
                    array[index] = element;
                }
            }
        }
        public T GetElement(int index)
        {
            T result = array[index];
            return result;
        }
        public void Remove(int index)
        {
            if(index < array.Length)
            {
                if(!array[index].Equals(default(T)))
                {
                    array[index] = default(T);
                    for(int i = index; i < array.Length - 1; i++)
                    {
                        array[i] = array[i + 1];
                        array[i + 1] = default(T);
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
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < array.Length; i++)
            {
                if (!array[i].Equals(default(T)))
                {
                    sb.Append(array[i] + " ");
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
            for(int i = start; i < array.Length; i++)
            {
                if(!array[i].Equals(default(T)))
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
            for(int i = 0; i < array.Length; i++)
            {
                buffer[i] = array[i];
            }
            array = null;
            array = buffer;
        }
        public T Min()
        {
            T minimum = array[0];

            for(int i = 1; i < array.Length; i++)
            {
                if(!(array[i].Equals(default(T))) && (minimum.CompareTo(array[i]) > 0))
                {
                    minimum = array[i];
                }
            }
            return minimum;
        }
        public T Max()
            {
            T maximum = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (!(array[i].Equals(default(T))) && (maximum.CompareTo(array[i]) < 0))
                {
                    maximum = array[i];
                }
            }
            return maximum;
        }
    }
}
