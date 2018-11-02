using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace PopularInterfaces
{
    class Collections
    {
        Stack TempsStacked { get; set; }
        SortedList TempsSorted { get; set; }
        ArrayList TempsUnSorted { get; set; }
        Hashtable TempsHashed { get; set; }
        Stopwatch sw;

        public Collections(Temperature[] temperatures)
        {
            sw = new Stopwatch();
            Console.WriteLine("Initializing Collections");
            TempsStacked = new Stack();
            TempsSorted = new SortedList();
            TempsUnSorted = new ArrayList();
            TempsHashed = new Hashtable();
            Console.WriteLine("");
            Console.WriteLine("Filling Collections");
            for (int i = 0; i < temperatures.Length; i+=2)
            {
                TempsStacked.Push(temperatures[i]);
                TempsSorted.Add(i, temperatures[i]);
                TempsUnSorted.Add(temperatures[i]);
                TempsHashed.Add(i, temperatures[i]);
            }
            for (int i = 1; i < temperatures.Length; i += 2)
            {
                TempsStacked.Push(temperatures[i]);
                TempsSorted.Add(i, temperatures[i]);
                TempsUnSorted.Add(temperatures[i]);
                TempsHashed.Add(i, temperatures[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Begining to Print Collections");
            PrintStack();
            Console.WriteLine("");
            PrintSorted();
            Console.WriteLine("");
            PrintUnSorted();
            Console.WriteLine("");
            PrintHashed();
        }

        public void PrintStack()
        {
            sw.Reset();
            sw.Start();
            Console.WriteLine("Starting Stack");
            while (TempsStacked.Count > 0)
            {
                //TempsStacked.Pop();
                 Console.WriteLine(((Temperature)TempsStacked.Pop()).Celsius);
            }
            sw.Stop();
            Console.WriteLine("Operation Took:{0}", sw.ElapsedTicks);
        }

        public void PrintSorted() {
            sw.Reset();
            sw.Start();
            Console.WriteLine("Starting Sorted");
            foreach (DictionaryEntry item in TempsSorted)
            {
                Console.WriteLine("Key:{0};Value:{1}", item.Key, ((Temperature)item.Value).Celsius);
            }
            Console.WriteLine("Operation Took:{0}", sw.ElapsedTicks);
        }



        public void PrintUnSorted()
        {

            sw.Reset();
            sw.Start();
            Console.WriteLine("Starting UnSorted");
            foreach (Temperature item in TempsUnSorted)
            {
                Console.WriteLine(item.Celsius);
            }
            Console.WriteLine("Operation Took:{0}", sw.ElapsedTicks);

        }
        public void PrintHashed() {
            sw.Reset();
            sw.Start();
            Console.WriteLine("Starting Hashed");
            foreach (DictionaryEntry item in TempsHashed)
            {
                Console.WriteLine("Key:{0};Value:{1}",item.Key, ((Temperature)item.Value).Celsius);
            }
            Console.WriteLine("Operation Took:{0}", sw.ElapsedTicks);
        
        }

    }
}
