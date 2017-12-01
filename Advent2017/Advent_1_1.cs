using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2017
{
    public class Advent_1_1
    {
        public int InverseCaptcha(string data)
        {
            // string of numbers

            var total = 0;

            // if a number matches the next number in line, add it to the total
            for (var i = 0; i < data.Length - 1; i++)
            {
                if (data.Substring(i,1) == data.Substring(i + 1,1))
                {
                    total += Convert.ToInt32(data.Substring(i,1));
                }
            }

            // list is circular, so see if the last element matches the first
            if (data.Substring(0,1) == data.Substring(data.Length - 1, 1))
            {
                total += Convert.ToInt32(data.Substring(data.Length - 1,1));
            }

            return total;
        }

        public int InverseCaptchaHalfway(string data)
        {
            // string of numbers

            var total = 0;
            int matchingPositionOffset = data.Length / 2; // setting type type to int forces integer division

            // if a number matches the next number in line, add it to the total
            for (var i = 0; i < data.Length; i++)
            {
                var matchingPosition = CalculateMatchingPosition(i, matchingPositionOffset, data.Length);

                if (data.Substring(i, 1) == data.Substring(matchingPosition, 1))
                {
                    total += Convert.ToInt32(data.Substring(i, 1));
                }
            }

            return total;
        }

        private int CalculateMatchingPosition(int currentPosition, int offset, int length)
        {
            var matchingPosition = currentPosition + offset;
            if (matchingPosition > length - 1)
            {
                matchingPosition -= length;
            }

            return matchingPosition;
        }

    }
}
