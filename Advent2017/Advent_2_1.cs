using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2017
{
    public class Advent_2_1
    {

        public int Checksum(string data)
        {
            var listData = ConvertStringDataToList(data);

            var checksum = 0;
            foreach (var row in listData)
            {
                var sorted = row.OrderBy(x => x); //returns row sorted in ascending order
                checksum += sorted.Last() - sorted.First();
            }

            return checksum;
        }

        public int ChecksumDivisible(string data)
        {
            var listData = ConvertStringDataToList(data);

            var checksum = listData.Sum(x=> CalculateRowChecksum(x));

            return checksum;
        }

        private List<List<int>> ConvertStringDataToList(string data)
        {
            var rows = data.Split(new []{"\r\n"}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var listData = rows.Select(x => x.Split('\t').Select(y=>Convert.ToInt32(y)).ToList()).ToList();

            return listData;
        }

        private int CalculateRowChecksum(List<int> row)
        {
            var checksum = 0;

            bool found = false;
            for (int i = 0; i < row.Count; i++)
            {
                for (int j = 0; j < row.Count; j++)
                {
                    if (i != j)
                    {
                        if (row[i] % row[j] == 0)
                        {
                            found = true;
                            checksum = row[i] / row[j];
                            break;
                        }                       
                    }
                }
                if (found) break;
            }

            return checksum;
        }
    }
}
