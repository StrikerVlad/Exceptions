using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exp
{
    class Program
    {

        static void Main(string[] args)
        {
            testArrayLength();
            testLink();
            Cls c = new Cls();
            testCls(c);

        }

        

        static void testLink()
        {
            try
            {
                WebRequest request = WebRequest.Create("https://www.freetomeetforgo.com");
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            Console.WriteLine(reader.ReadToEnd());
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Confirm");
            }
        }

        

        static void testArrayLength()
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 20);
            }
            try
            {

                arr[12] = 3;
                for (int j = 0; j < arr.Length + 1; j++)
                {
                    arr[j] += 2;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Confirm");
            }

        }

       
        static void testCls(Cls c)
        {
            Cls f = new Cls(1, 0);
            try
            {
                int res = f.division();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
