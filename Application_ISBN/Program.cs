using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_ISBN
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int sum = 0;
            int multiplier = 10;
            int lastdigit = 0;
            string ISBN;
            string preISBN="";
            Console.Write("\n Please enter the productID:");
            input = Console.ReadLine().ToString();                   
            List<int> IDList = new List<int>();
            List<int> list = new List<int>();
            for(int i = 3; i < input.Length; i++)
            {
                int number = int.Parse(input[i].ToString());
                int bigNum = number * multiplier;
                IDList.Add(number);
                list.Add(bigNum);
                multiplier--;
            }
          
            for(int i = 0; i < list.Count; i++)
            {
                sum = sum + list[i];
            }
            while ((sum+lastdigit)%11!=0)
            {
                lastdigit++;             
            }
            
            for(int i = 0; i < IDList.Count; i++)
            {
              
                string number = IDList[i].ToString();
                preISBN = preISBN + number;
               
            }
            if (lastdigit != 10)
            {
                ISBN = preISBN + lastdigit.ToString();
            }
            else
            {
                ISBN = preISBN + "X";
            }
            Console.WriteLine("The ISBN number is:"+" "+ISBN);
        }
    }
}
