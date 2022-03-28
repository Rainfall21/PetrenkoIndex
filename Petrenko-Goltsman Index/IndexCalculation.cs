using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petrenko_Goltsman_Index
{
    class IndexCalculation
    {
        public double indexPetrenkoRus(string text)
        {
            double index = 0.5d;

            for (double i = 1.5d; i - 0.5d < text.Count(char.IsLetter); i++)
            {
                index = index + i;
            }

            index = index * text.Count(char.IsLetter);

            return index;
        }

        public double indexPetrenkoEng(string text)
        {
            string[] textArray = text.Split("|");

            double totalIndex = 0;

            foreach (string obj in textArray)
            {
                double index = 0.5d;

                for (double i = 1.5d; i - 0.5d < obj.Count(char.IsLetter); i++)
                {
                    index = index + i;
                }

                index = index * obj.Count(char.IsLetter);

                totalIndex += index;
            }

            return totalIndex;
        }
    }
}
