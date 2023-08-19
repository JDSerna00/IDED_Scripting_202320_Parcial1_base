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
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            return 0;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;

            return result;
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