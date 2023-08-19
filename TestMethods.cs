using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject1
{
    internal class TestMethods
    {
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {
            Stack<int> tempStack = new Stack<int>();           
            Stack<int> result = new Stack<int>();

            while (sourceStack.Count > 0)
            {
                int currentNumber = sourceStack.Pop();
                int greaterSucceedingValue = -1;

                foreach (int value in tempStack)
                {
                    if (value > currentNumber)
                    {
                        greaterSucceedingValue = value;
                        break;
                    }
                }

                result.Push(greaterSucceedingValue);
                tempStack.Push(currentNumber);
            }
            
            Stack<int> revResult = new Stack<int>();

            while (result.Count > 0)
            {
                revResult.Push(result.Pop());
            }

            return revResult;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> dictionary = new Dictionary<int, EValueType>();

            foreach (int number in sourceArr)
            {
                if (number == 1)
                {
                    dictionary[number] = EValueType.Prime;
                }

                if (number % 2 == 0)
                {
                    dictionary[number] = EValueType.Two;
                }
                else if (number % 3 == 0)
                {
                    dictionary[number] = EValueType.Three;
                }
                else if (number % 5 == 0)
                {
                    dictionary[number] = EValueType.Five;
                }
                else if (number % 7 == 0)
                {
                    dictionary[number] = EValueType.Seven;
                }
                else if (IsPrime(number))
                {
                    dictionary[number] = EValueType.Prime;
                }
            }

            return dictionary;
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            int count = 0;

            foreach (var kvp in sourceDict)
            {
                if (kvp.Value == type)
                {
                    count++;
                }
            }

            return count;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            
            List<KeyValuePair<int, EValueType>> sortedList = new List<KeyValuePair<int, EValueType>>(sourceDict);

            for (int i = 1; i < sortedList.Count; i++)
            {
                var currentItem = sortedList[i];
                int j = i - 1;

                while (j >= 0 && currentItem.Key > sortedList[j].Key)
                {
                    sortedList[j + 1] = sortedList[j];
                    j--;
                }

                sortedList[j + 1] = currentItem;
            }

            Dictionary<int, EValueType> sortedDictionary = new Dictionary<int, EValueType>();
            foreach (var kvp in sortedList)
            {
                sortedDictionary.Add(kvp.Key, kvp.Value);
            }

            return sortedDictionary;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;

            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            return result;
        }        
    }
}