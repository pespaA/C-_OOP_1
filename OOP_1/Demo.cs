using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

using Common;
namespace OOP_1
{
    enum Grades
    {
        //Lables
        A , B , C , D , F=-1
    }

    enum Gender
    {
        Male ,
        Female ,
        M = 0,
        F = 1,
    }
    internal class Demo
    {
        public static void Demo0()
        {
            #region What Is Access Modifiers 
            TypeA obj = new TypeA();
            //obj.x = 1;// not Valid
            //obj.y = 1;// not Valid
            obj.z = 2;// Valid
            #endregion
            #region Enum 
            //Grades Math = new Grades();
            //Math = Grades.A;
            //if (Math == Grades.A)
            //    Console.WriteLine("Cong A+");
            //else 
            //    Console.WriteLine("Sorry you fail");

            #endregion
            #region Struct 
            Point P1 = new Point(4,2);// 'new' just for constructor Selection
            // Declare For Object From Type "Point"
            // Clr Will Allocate 8 Bytes Unitialiized At Stack
           // Console.WriteLine(P1);
            #endregion
            #region What Is OOP 

            #endregion
            #region Encapsulation 
            Employee emp = new Employee(10,"Omar", 200000);
            //emp.Id = 20;
            //Console.WriteLine(emp.Id);

            //emp.SetName("Ahmed");
            //Console.WriteLine(emp.GetName());

            //emp.Salary = 3000000;//set by Property
            //Console.WriteLine(emp.Salary);//get by Property

            #endregion
            #region Indexe 

            #endregion
        }
    }
}
