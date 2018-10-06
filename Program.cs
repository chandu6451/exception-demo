using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;

            try
            {
                Console.Write("Enter Number 1 : ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Number 2 : ");
                num2 = Convert.ToInt32(Console.ReadLine());

                result = num1 / num2;

                int[] arr = new int[5];

                arr[2] = 10;
                arr[4] = 34;
                //arr[5] = 76;

                Employee emp = null;

                emp.ID = 10;
                emp.Name = "ABC";
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block Executed");
            }
            Console.ReadKey();
        }
    }
}
