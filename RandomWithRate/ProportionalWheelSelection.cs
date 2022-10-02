using System;
using System.Collections.Generic;

namespace RandomWithRate
{
    public class ProportionalWheelSelection
    {
        private static readonly Random Random = new Random();

        public static Item SelectItem(List<Item> items)
        {
            int poolSize = 0;
            for (int i = 0; i < items.Count; i++)
            {
                poolSize += items[i].Rate;
            }

            int randomNumber = Random.Next(0, poolSize) + 1;

            int accumulatedProbability = 0;
            for (int i = 0; i < items.Count; i++)
            {
                accumulatedProbability += items[i].Rate;
                if (randomNumber <= accumulatedProbability)
                {
                    return items[i];
                }
            }

            return null;
        }
    }
}