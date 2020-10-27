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