using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Atm
{
    class OperationsList
    {
        public static List<string> operations = new List<string>();
        public  static void AddOperations(string operation)
        {
            operations.Add(operation);           
        }
        public static  void ShowOperations()
        {
            if (operations.Count==0)
            {
                Console.WriteLine("You have not operation in the card");
            }
            foreach (var operation in operations)
            {     
                Console.WriteLine(operation);
            }
        }
    }
}
