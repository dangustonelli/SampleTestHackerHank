using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



public class Program
{

    /*
     * Complete the 'usernamesSystem' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts STRING_ARRAY u as parameter.
     */

    public static List<string> usernamesSystem(List<string> u)
    {
        List<string> usernameKeys = new List<string>();
        List<string> orderList = new List<string>();
        int contador = 0;

        foreach (var item in u)
        {
            contador = orderList.Where(temp => temp.Contains(item.ToString()))
                    .Select(temp => temp)
                    .Count();

            if (contador == 0)
            {
                orderList.Add(item.ToString());
            }
            else
            {
                orderList.Add(item.ToString() + contador);
            }
        }

        return orderList;

    }


    public class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);


            int uCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> u = new List<string>();

            for (int i = 0; i < uCount; i++)
            {
                string uItem = Console.ReadLine();
                u.Add(uItem);
            }

            List<string> result = Program.usernamesSystem(u);

            Console.WriteLine(String.Join("\n", result));

            //console.Flush();
            //textWriter.Close();

            //Console.WriteLine(usernamesSystem(u));
            Console.ReadLine();
        }
    }
}
