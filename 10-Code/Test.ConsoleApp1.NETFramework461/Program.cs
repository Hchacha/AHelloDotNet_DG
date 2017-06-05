using QX_Frame.Helper_DG;
using QX_Frame.Helper_DG.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ConsoleApp1.NETFramework461
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = Redis_Helper_DG.Client;

            
            var values =client.GetAllKeys();

            foreach (var item in values)
            {
                Console.WriteLine(item+"\t"+Redis_Helper_DG.Client.Get<string>(item).ToString());
            }

            Console.WriteLine("any key to exit ...");
            Console.ReadKey();
        }
    }
    public class Student
    {
        public int StuId { get; set; }
        public string StuName { get; set; }

        public void SetStudentInfo() => Console.WriteLine("...stu info ...");

        public Student GetStudentInfo() => new Student { StuId = 1, StuName = "zhangsan" };
    }
}
