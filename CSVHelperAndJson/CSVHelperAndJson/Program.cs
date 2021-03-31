using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVHelperAndJson
{
    class Program
    {
        static void Main(string[] args)
        {
            //CSVHandler.ImplementCSVDataHandling();
            ReadCSV_And_WriteJSON.ImplementCSVToJSON();
            Console.ReadKey();
        }
    }
}
