using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Employee
    {
        //int Id;
        //string Name;
        //Gender Gender;
        #region Attributes
        public int Id;
        public string Name;
        private decimal salary;
        #endregion
        #region Constructor
        public Employee(int _Id,string _Name, decimal _Salary)
        {
            Id = _Id;
            Name = _Name;
            salary = _Salary;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Id : {Id}\nName : {Name}\nSalary : {salary}";
        }
        #endregion

        #region Encapsulation
        // 1- Encapsulation: Sperate Data Defeition [Attributes]
        // From It Is Use ( Getter / Setter - Property - Indexer)

        // 1- Getter / Setter
        // Getter 
        public string GetName()
        {
            return Name ;
        }
        // Setter
        public void SetName(string _Name)
        {
            Name = _Name.Length<=5?_Name:_Name.Substring(0,5) ;
            //Controll Data Validation
        }

        // 2- Applying Property
        // 2.1 Full Property //Attribute should by private and First char is small 'salary'
        public decimal Salary //propfull+tap
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value/*<=4000?value:4000*/;//Controll Data Validation
            }
        }
       
        // 2.2 Automatic Property
        //public int Age;
        public int Age { get; set; } // prop+tap
        

        #endregion

    }
}
