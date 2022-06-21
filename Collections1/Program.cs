using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections1
{
    class Program
    {
        public static object MessageBox { get; private set; }

        static void Main(string[] args)
        {

            ArrayList array = new ArrayList();
            array.Add("Gunel");
            array.Add("  ");
            array.Add("y");
            array.Add("8");
            array.Add(7);
            foreach (var item in array)
            {

            }


            ArrayList array1 = new ArrayList();
            array1.Add("sUN");
            array1.Add("G");
            array1.Add(88);
            array1.Add(" ");
            array.AddRange(array1);
            foreach (var item in array)
            {
                //Console.WriteLine(item); 


            }
            int[] nums = { 4, 8, 99, };
            array1.AddRange(nums);
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }





            List<string> names = new List<string>();
            names.Add("Ali");
            names.Add("Coni");
            names.Add("Mubu");
            names.Add("Xan");
            names.Add("Asya");

            Console.WriteLine(names.Count);
            // foreach (var item in names)
            {
                // Console.WriteLine(item);

            }

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(6);
            numbers.Add(11);
            numbers.Add(16);


            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];

                Console.WriteLine(sum);
            }


            numbers.Remove(16);
            numbers.ForEach(number => Console.WriteLine(number));
            names.Remove("Xan");
            names.Remove("Coni");
            names.RemoveAt(2);

            names.ForEach(name => Console.WriteLine(name));

            if (names.Contains("Coni"))
            {
                Console.WriteLine("Bu ad movcuddur");
            }
            else Console.WriteLine("Bu ad movcud deyil");



            Stack<int> myStack = new Stack<int>();

            myStack.Push(6);
            myStack.Push(7);
            myStack.Push(20);

            //Console.WriteLine(myStack.Count);

            //if (myStack.Count > 0) 

            //    Console.WriteLine(myStack.Peek());


            //Console.Write(myStack.Pop() + ",");
            //Console.WriteLine(myStack.Peek());
            //Console.Write(myStack.Pop() + ",");


            //Console.WriteLine ( myStack.Count);
            Console.WriteLine(myStack.Contains(7 ));


            Queue<string> LettersQ = new Queue<string>();
            LettersQ.Enqueue("G");
            LettersQ.Enqueue("U");
            LettersQ.Enqueue("N");
            LettersQ.Enqueue("E");
            LettersQ.Enqueue("L");
            foreach (var item in LettersQ)
            {
                Console.WriteLine(item);
                

            }



            //Console.WriteLine(LettersQ.Count);

            //while (LettersQ.Count > 0) ;
            //Console.WriteLine(LettersQ.Dequeue());

           // Console.WriteLine(LettersQ.Count); 
            if(LettersQ.Count>0)
            {
                Console.WriteLine(LettersQ.Peek());
            }

            SortedList<int, string> RowProduct = new SortedList<int, string>();

            RowProduct.Add(10 , "alma");
            RowProduct.Add(6, "alca");
            RowProduct.Add(5, "alba");
            foreach (var item in RowProduct)
            {
                Console.WriteLine(item);
                Console.WriteLine(RowProduct[6]);
            }


        }






    }
}
