using System;

namespace PopularInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Using Generics to a you name it, it has it class.");
            //// Test IComparables
            //TestSmaller();
            //Console.WriteLine("");
            //TestBigger();
            //Console.WriteLine("");
            //TestEqual();
            //Console.WriteLine("");
            ////Test IClone
            //CloneMe();
            //Console.WriteLine("");
            ////Test IList
            //IterateMe();
            //Console.WriteLine("");
            
            //// Show IDisposable
            //Console.ReadLine();


            Console.WriteLine("Showing Collections");
            TestCollections();
            Console.ReadLine();
        }

        private static void TestSmaller()
        {
            Console.WriteLine("Testing Smaller on Left");
            Temperature ta_reading1 = new Temperature() { Celsius = 20 };
            Temperature ta_reading2 = new Temperature() { Celsius = 22 };
            Temperature ta_reading3 = new Temperature() { Celsius = 23 };

            Temperature eilat_reading1 = new Temperature() { Celsius = 40 };
            Temperature eilat_reading2 = new Temperature() { Celsius = 42 };
            Temperature eilat_reading3 = new Temperature() { Celsius = 13 };

            YouNameIt<Temperature> ta_temperatures = new YouNameIt<Temperature>(new Temperature[3] { ta_reading1,
            ta_reading2,ta_reading3});

            YouNameIt<Temperature> eilat_temperatures = new YouNameIt<Temperature>(new Temperature[3] { eilat_reading1,
            eilat_reading2,eilat_reading3});

            // Result that is -1 left side is bigger
            // Result that is 1 right side is bigger
            // Result that is 0 they are equal
            int comp = ta_temperatures.CompareTo(eilat_temperatures);
            string res = GetComparisonString(comp);
            Console.WriteLine("Result {0}", res);
        }

        private static string GetComparisonString(int compareResult)
        {
            if (compareResult == 0) return "Both sides are equal";
            if (compareResult == -1) return "Left bigger than right";
            return "Right bigger than left";
        }

        private static void TestBigger()
        {
            Console.WriteLine("Testing Smaller on Right");
            Temperature ta_reading1 = new Temperature() { Celsius = 40 };
            Temperature ta_reading2 = new Temperature() { Celsius = 32 };
            Temperature ta_reading3 = new Temperature() { Celsius = 23 };

            Temperature eilat_reading1 = new Temperature() { Celsius = 20 };
            Temperature eilat_reading2 = new Temperature() { Celsius = 12 };
            Temperature eilat_reading3 = new Temperature() { Celsius = 13 };

            YouNameIt<Temperature> ta_temperatures = new YouNameIt<Temperature>(new Temperature[3] { ta_reading1,
            ta_reading2,ta_reading3});

            YouNameIt<Temperature> eilat_temperatures = new YouNameIt<Temperature>(new Temperature[3] { eilat_reading1,
            eilat_reading2,eilat_reading3});

            // Result that is -1 left side is bigger
            // Result that is 1 right side is bigger
            // Result that is 0 they are equal
            int comp = ta_temperatures.CompareTo(eilat_temperatures);
            string res = GetComparisonString(comp);
            Console.WriteLine("Result {0}", res);
        }

        private static void TestEqual()
        {
            Console.WriteLine("Testing Equal");
            Temperature ta_reading1 = new Temperature() { Celsius = 40 };
            Temperature ta_reading2 = new Temperature() { Celsius = 42 };
            Temperature ta_reading3 = new Temperature() { Celsius = 13 };

            Temperature eilat_reading1 = new Temperature() { Celsius = 40 };
            Temperature eilat_reading2 = new Temperature() { Celsius = 42 };
            Temperature eilat_reading3 = new Temperature() { Celsius = 13 };

            YouNameIt<Temperature> ta_temperatures = new YouNameIt<Temperature>(new Temperature[3] { ta_reading1,
            ta_reading2,ta_reading3});

            YouNameIt<Temperature> eilat_temperatures = new YouNameIt<Temperature>(new Temperature[3] { eilat_reading1,
            eilat_reading2,eilat_reading3});

            // Result that is -1 left side is bigger
            // Result that is 1 right side is bigger
            // Result that is 0 they are equal
            int comp = ta_temperatures.CompareTo(eilat_temperatures);
            string res = GetComparisonString(comp);
            Console.WriteLine("Result {0}", res);
        }

        private static void CloneMe()
        {
            Console.WriteLine("Begining Cloning");
            Temperature ta_reading1 = new Temperature() { Celsius = 40 };
            Temperature ta_reading2 = new Temperature() { Celsius = 42 };
            Temperature ta_reading3 = new Temperature() { Celsius = 13 };
            YouNameIt<Temperature> ta_temperatures = new YouNameIt<Temperature>(new Temperature[3] { ta_reading1,
            ta_reading2,ta_reading3});
            Console.WriteLine("Object Version {0}", ta_temperatures.YouNameItVersion);
            for (int i = 0; i < ta_temperatures.Readings.Length; i++)
            {
                Console.WriteLine("Readings {0}:{1}", i, ta_temperatures.Readings[i].Celsius);
            }

            YouNameIt<Temperature> cloned_ta_temps = (YouNameIt<Temperature>)ta_temperatures.Clone();
            Console.WriteLine("Clone result");

            Console.WriteLine("Clone Version {0}", cloned_ta_temps.YouNameItVersion);
            for (int i = 0; i < cloned_ta_temps.Readings.Length; i++)
            {
                Console.WriteLine("Readings {0}:{1}", i, cloned_ta_temps.Readings[i].Celsius);
            }
        }

        private static void IterateMe()
        {
            Console.WriteLine("Begining Iteration");
            Console.WriteLine("Doing iteration without accessing internal readings");
            Temperature ta_reading1 = new Temperature() { Celsius = 40 };
            Temperature ta_reading2 = new Temperature() { Celsius = 42 };
            Temperature ta_reading3 = new Temperature() { Celsius = 13 };
            YouNameIt<Temperature> ta_temperatures = new YouNameIt<Temperature>(new Temperature[3] { ta_reading1,
            ta_reading2,ta_reading3});
            Console.WriteLine("Object Version {0}", ta_temperatures.YouNameItVersion);
            Console.WriteLine("Running with a foreach loop");
            foreach (Temperature t in ta_temperatures)
            {
                Console.WriteLine("Readings {0}", t.Celsius);
            }

            Temperature ta_reading4 = new Temperature() { Celsius = 53 };

            ta_temperatures.Add(ta_reading4);
            // Since we added a reference to an object both readings will be the same
            ta_reading4.Celsius = 54;
            ta_temperatures.Insert(10, ta_reading4);
            Console.WriteLine("");
            Console.WriteLine("Object Version {0}", ta_temperatures.YouNameItVersion);
            Console.WriteLine("Running with a foreach loop after adding items to IList");
            foreach (Temperature t in ta_temperatures)
            {
                Console.WriteLine("Readings {0}", t.Celsius);
            }

        }

        private static void TestCollections()
        {
            Temperature[] temps = new Temperature[20];
            Random rnd = new Random();
            for (int i = 0; i < temps.Length; i++)
            {
                temps[i] = new Temperature() { Celsius = rnd.Next(0, 45) };
            }

            Collections collectionComparer = new Collections(temps);

        }
    }
}
