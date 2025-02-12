namespace Fundamentals2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] sampleArrayInt = { 2, 4, 6, 8, 10 };
            float[] floatArray = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f };
            double[] doubleArray = { 1.1111111, 2.2222222, 3.3333333, 4.4444444, 5.5555555 };
            InputSwitch();
            ArraysAndLoops();
            OutputArrayInt(sampleArrayInt);
            Overload(floatArray);
            Overload(doubleArray);
            AverageIntToFloat(sampleArrayInt);
            AverageOverload(floatArray);
            AverageOverload(doubleArray);
            RandomArray();
        }

        static void InputSwitch()
        {
            Console.WriteLine("Enter a W A S D key");
            string? userInput = Console.ReadLine();
            string caseSensitive = userInput.ToUpper();
            switch (caseSensitive)
            {
                case "W":
                    Console.WriteLine("You moved up.");
                    break;
                case "A":
                    Console.WriteLine("You moved left.");
                    break;
                case "S":
                    Console.WriteLine("You moved down.");
                    break;
                case "D":
                    Console.WriteLine("You moved right");
                    break;
                default:
                    Console.WriteLine("You did not move.");
                    break;
            }
        }
        static void ArraysAndLoops()
        {
            int[] allValues = {100, 94, 159, -783, 132, 179, 47, 107, 135, 50};
            for (int i = allValues.Length; i > 0; i--)
            {
                Console.WriteLine(allValues[i - 1]);
            }
            bool isInArray = false;
            while (!isInArray)
            {
                Console.WriteLine("Enter a number.");
                int userNumberInput = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < allValues.Length; i++)
                {
                    if (allValues[i] == userNumberInput)
                    {
                        isInArray = true;
                    }
                }
            }

            int totalValue = 0;
            for (int i = 0; i < allValues.Length; i++)
            {
                totalValue += allValues[i];
            }
            int averageValue = totalValue / allValues.Length;
            Console.WriteLine("The average value of the array is " + averageValue);
            for (int i = 0; i < allValues.Length; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(allValues[i]);
                
            }
            Console.WriteLine();
            for (int i = 3; i < allValues.Length; i++)
            {
                if (i % 3 != 0)
                {
                    continue;
                }
                Console.WriteLine(allValues[i-1]);
            }
            Console.WriteLine("Enter three numbers.");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int rangeMin = Convert.ToInt32(Console.ReadLine());
            int rangeMax = Convert.ToInt32(Console.ReadLine());
            int[] randomArray = new int[arraySize];
            Random rnd = new Random();

            for(int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(rangeMin, rangeMax);
            }
        }

        static void OutputArrayInt(int[] exampleArray)
        {
            for (int i = 0; i < 0; i++)
            {
                Console.WriteLine(exampleArray[i]);
            }
        }
        static void Overload(float[] floatArray)
        {
            for (int i = 0; i < 0; i++)
            {
                Console.WriteLine(floatArray[i]);
            }
        }
        static void Overload(double[] doubleArray)
        {
            for (int i = 0; i < 0; i++)
            {
                Console.WriteLine(doubleArray[i]);
            }
        }
        static void AverageIntToFloat(int[]sampleArrayInt)
        {
            float totalValue = 0;
            for (int i = 0; i < sampleArrayInt.Length; i++)
            {
                totalValue += sampleArrayInt[i];
            }
            float averageValue = totalValue / Convert.ToSingle(sampleArrayInt.Length);
            Console.WriteLine("The average value of the array is " + averageValue);
        }
        static void AverageOverload(float[]sampleArray)
        {
            double totalValue = 0;
            for (int i = 0; i < sampleArray.Length; i++)
            {
                totalValue += sampleArray[i];
            }
            double averageValue = totalValue / sampleArray.Length;
            Console.WriteLine("The average value of the array is " + averageValue);
        }
        static void AverageOverload(double[] sampleArray)
        {
            double totalValue = 0;
            for (int i = 0; i < sampleArray.Length; i++)
            {
                totalValue += sampleArray[i];
            }
            double averageValue = totalValue / sampleArray.Length;
            Console.WriteLine("The average value of the array is " + averageValue);
        }

        static void RandomArray()
        {
            Console.WriteLine("Enter three numbers.");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int rangeMin = Convert.ToInt32(Console.ReadLine());
            int rangeMax = Convert.ToInt32(Console.ReadLine());
            int[] randomArray = new int[arraySize];
            Random rnd = new Random();

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(rangeMin, rangeMax);
            }
            //Console.WriteLine(randomArray);
        }
    }
}

    
