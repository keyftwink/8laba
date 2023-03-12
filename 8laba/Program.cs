
namespace _8laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Objects<int> intArray = new Objects<int>(10);
            Objects<string> stringArray = new Objects<string>(10);
            Objects<double> doubleArray = new Objects<double>(10);

            intArray.Add(0, 1);
            stringArray.Add(0, "fe2fsddsf");
            stringArray.Add(1, "fe2f32dsf");
            stringArray.Add(2, "532523fsddsf");
            doubleArray.Add(0, 0.42);

            Console.WriteLine(stringArray.Get(0));
            stringArray.Remove(1);
            Console.WriteLine(stringArray.Get(1));

        }
    }

    class Objects<T>
    {
        int Lenght { get; set; }
        T[] Array { get; set; }

        public Objects(int lenght)
        {
            Array = new T[lenght];
            this.Lenght = lenght;
        }

        public void Add(int index, T obj)
        {

            Array[index] = obj;
        }

        public void Remove(int index)
        {
            T[] newArray = new T[Array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = Array[i];
            }

            for (int i = index + 1; i < Array.Length; i++)
            {
                newArray[i - 1] = Array[i];
            }

            Array = newArray;
        }

        public T Get(int index)
        {
            return Array[index];
        }

        public int GetLenght()
        {
            return Array.Length;
        }
    }
}