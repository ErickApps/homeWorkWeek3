using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace homework3.Models
{
    public class Model
    {
        public int Num { get; set; }
        

        public static List<int> multiplication(int number)
        {
            List<int> list = new List<int>();
            int counter = number;
            number = number*number;
            int result;

            for (int i = 1; i <= counter; i++)
            {

                for (int j = 1; j <= counter; j++)
                {

                    result = j*i;
                    list.Add(result);
                }

                
            }
            return list;
        }
    }
}