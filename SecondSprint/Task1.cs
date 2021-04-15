using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSpring
{
    class Employee
    {
        internal string name;
        DateTime hiringDate;
        public Employee(string name, DateTime hiringDate)
        {
            this.name = name;
            this.hiringDate = hiringDate;
        }
        public int Experience()
        {
            return (int)(DateTime.Now - hiringDate).TotalDays / 360;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{name} has {Experience()} years of experience");
        }
    }
    class Developer : Employee
    {
        string programmingLanguage;
        public Developer(string name, DateTime hiringDate, string programmingLanguage) : base(name, hiringDate)
        {
            this.programmingLanguage = programmingLanguage;
        }
        public new void ShowInfo()
        {
            Console.WriteLine($"{name} has {Experience()} years of experience");
            Console.WriteLine($"{name} is {programmingLanguage} programmer");
        }
    }
    class Tester : Employee
    {
        bool isAuthomation;
        public Tester(string name, DateTime hiringDate, bool isAuthomation) : base(name, hiringDate)
        {
            this.isAuthomation = isAuthomation;
        }
        public new void ShowInfo()
        {
            if (isAuthomation) Console.WriteLine($"{name} is authomated tester and has {Experience()} year(s) of experience");
            else Console.WriteLine($"{name} is manual tester and has {Experience()} year(s) of experience");
        }
    }
}
