//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections.Generic;
//namespace GenericsTopLearn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//    }
//}

//==============================================================================================================



using System;
  using System.Collections.Generic;
namespace GenericSampleApp
{
    /// <summary>  
    /// SampleGenericArray  
    /// </summary>  
    /// <typeparam name="T"></typeparam>  
    public class SampleGenericArray<T>
    {
        private T[] array;
        /// <summary>  
        /// SampleGenericArray - Constructor  
        /// </summary>  
        /// <param name="size">size</param>  
        public SampleGenericArray(int size)
        {
            array = new T[size + 1];
        }
        /// <summary>  
        /// getMyItem - Get Property to return the value  
        /// </summary>  
        /// <param name="index">index</param>  
        /// <returns></returns>  
        public T getMyItem(int index)
        {
            return array[index];
        }
        /// <summary>  
        /// setMyItem - Set the Property to set value  
        /// </summary>  
        /// <param name="index">index</param>  
        /// <param name="value">value</param>  
        public void setMyItem(int index, T value)
        {
            array[index] = value;
        }
    }
    public class SampleTest
    {
        /// <summary>  
        /// Main  
        /// </summary>  
        /// <param name="args"></param>  
        public static void Main(string[] args)
        {
            //Declaring an int array  
            SampleGenericArray<int> intArray = new SampleGenericArray<int>(5);
            //Setting up of values  
            for (int c = 0; c < 5; c++)
            {
                intArray.setMyItem(c, c * 5);
            }
            //Retrieving the values  
            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.getMyItem(c) + " ");
            }
            Console.WriteLine();
            //Declaring a character array  
            SampleGenericArray<char> charArray = new SampleGenericArray<char>(5);
            //Setting values  
            for (int c = 0; c < 5; c++)
            {
                charArray.setMyItem(c, (char)(c + 97));
            }
            //Retrieving the values  
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.getMyItem(c) + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

//==============================================================================================================


/// <summary>
/// List Of All  DataType
/// </summary>
//namespace Gen
//{

//    class ListInt
//    {
//        int[] ints = new int[3];
//        int currentIndex;

//        public int Length { get { return ints.Length; } }

//        public void Add(int i)
//        {
//            if (currentIndex == ints.Length)
//                Grow();
//            ints[currentIndex++] = i;
//        }

//        private void Grow()
//        {
//            int[] temp = new int[ints.Length * 2];
//            Array.Copy(ints, temp, ints.Length);
//            ints = temp;
//        }

//        public int Get(int index)
//        {
//            return ints[index];
//        }
//    }

//    //---------------------------------string List
//    class ListString
//    {
//        string[] ints = new string[3];
//        int currentIndex;

//        public int Length { get { return ints.Length; } }

//        public void Add(string i)
//        {
//            if (currentIndex == ints.Length)
//                Grow();
//            ints[currentIndex++] = i;
//        }

//        private void Grow()
//        {
//            string[] temp = new string[ints.Length * 2];
//            Array.Copy(ints, temp, ints.Length);
//            ints = temp;
//        }

//        public string Get(int index)
//        {
//            return ints[index];
//        }
//    }
//    //------------------------------------------->
//    //---------------------------------Double List
//    class ListDouble
//    {
//        double[] ints = new double[3];
//        int currentIndex;

//        public int Length { get { return ints.Length; } }

//        public void Add(double i)
//        {
//            if (currentIndex == ints.Length)
//                Grow();
//            ints[currentIndex++] = i;
//        }

//        private void Grow()
//        {
//            double[] temp = new double[ints.Length * 2];
//            Array.Copy(ints, temp, ints.Length);
//            ints = temp;
//        }

//        public double Get(int index)
//        {
//            return ints[index];
//        }
//    }
//    //------------------------------------------->




//    //---------------------------------Float List
//    class ListFloat
//    {
//        float[] ints = new float[3];
//        int currentIndex;

//        public int Length { get { return ints.Length; } }

//        public void Add(float i)
//        {
//            if (currentIndex == ints.Length)
//                Grow();
//            ints[currentIndex++] = i;
//        }

//        private void Grow()
//        {
//            float[] temp = new float[ints.Length * 2];
//            Array.Copy(ints, temp, ints.Length);
//            ints = temp;
//        }

//        public float Get(int index)
//        {
//            return ints[index];
//        }
//    }
//    //------------------------------------------->



//    //---------------------------------bool List
//    class Listbool
//    {
//        bool[] ints = new bool[3];
//        int currentIndex;

//        public int Length { get { return ints.Length; } }

//        public void Add(bool i)
//        {
//            if (currentIndex == ints.Length)
//                Grow();
//            ints[currentIndex++] = i;
//        }

//        private void Grow()
//        {
//            bool[] temp = new bool[ints.Length * 2];
//            Array.Copy(ints, temp, ints.Length);
//            ints = temp;
//        }

//        public bool Get(int index)
//        {
//            return ints[index];
//        }
//    }
//    //------------------------------------------->


//    //---------------------------------long List
//    class longList
//    {
//        long[] ints = new long[3];
//        int currentIndex;

//        public int Length { get { return ints.Length; } }

//        public void Add(long i)
//        {
//            if (currentIndex == ints.Length)
//                Grow();
//            ints[currentIndex++] = i;
//        }

//        private void Grow()
//        {
//            long[] temp = new long[ints.Length * 2];
//            Array.Copy(ints, temp, ints.Length);
//            ints = temp;
//        }

//        public long Get(int index)
//        {
//            return ints[index];
//        }
//    }
//    //------------------------------------------->


//    //---------------------------------char  List
//    class Listchar
//    {
//        char[] ints = new char[3];
//        int currentIndex;

//        public int Length { get { return ints.Length; } }

//        public void Add(char i)
//        {
//            if (currentIndex == ints.Length)
//                Grow();
//            ints[currentIndex++] = i;
//        }

//        private void Grow()
//        {
//            char[] temp = new char[ints.Length * 2];
//            Array.Copy(ints, temp, ints.Length);
//            ints = temp;
//        }

//        public char Get(int index)
//        {
//            return ints[index];
//        }
//    }
//    //------------------------------------------->

//    /// <summary>
//    /// //////////////Generic
//    class List<T>
//    {
//        T[] ints = new T[3];
//        int currentIndex;

//        public int Length { get { return ints.Length; } }

//        public void Add(T i)
//        {
//            if (currentIndex == ints.Length)
//                Grow();
//            ints[currentIndex++] = i;
//        }

//        private void Grow()
//        {
//            T[] temp = new T[ints.Length * 2];
//            Array.Copy(ints, temp, ints.Length);
//            ints = temp;
//        }
//        public T Get(int index)
//        {
//            return ints[index];
//        }
//    }
//    /// </summary>

//    class MainClass
//    {
//        static void Main()
//        {
//            ListInt myInts = new ListInt();
//            myInts.Add(12);
//            myInts.Add(25);
//            myInts.Add(92);
//            myInts.Add(5);
//            for (int i = 0; i < myInts.Length; i++)
//            {
//                Console.WriteLine(myInts.Get(i));

//            }
//            Console.ReadLine();
//        }
//    }
//}

