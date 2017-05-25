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

            Student stu = new Student { StuId=123,StuName="name 123"};

            List<Student> stuList = new List<Student> { new Student { StuId=1,StuName="11"},new Student { StuId=2,StuName="22"} };

            var stulist2 = stuList;

            stulist2.FirstOrDefault().StuName = "3333333";

            foreach (var item in stuList)
            {
                Console.WriteLine(item.StuName);
            }
            

            Console.WriteLine("any key to exit ...");
            Console.ReadKey();
        }
    }
    public class Student
    {
        public int StuId { get; set; }
        public string StuName { get; set; }

        public void SetStudentInfo()=> Console.WriteLine("...stu info ...");

        public Student GetStudentInfo()=> new Student { StuId = 1, StuName = "zhangsan" };
    }
}
