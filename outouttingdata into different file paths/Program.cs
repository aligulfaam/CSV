using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace outouttingdata_into_different_file_paths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder csvcontent = new StringBuilder();
            csvcontent.AppendLine("Name,Age,ID,Height");
            csvcontent.AppendLine("Bob,43,2237,5'9");
            string csvpath = "C:\\Users\\ali_gulfaam\\Desktop\\outputtingdata.csv";
            File.WriteAllText(csvpath, csvcontent.ToString());

        }
    }
}
