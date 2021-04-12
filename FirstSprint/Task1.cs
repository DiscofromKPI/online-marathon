using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSpring
{
    class MyAccessModifiers
    {
        int birthYear;
        protected string personalInfo;
        private protected string IdNumber;
        public const byte averageMiddleAge = 50;
        internal string Name { get; set; }
        public string NickName
        {
            get
            {
                return NickName;
            }
            internal set
            {
                NickName = value;
            }
        }

        public MyAccessModifiers(int birthYear, string IdNumber, string personalInfo)
        {
            this.birthYear = birthYear;
            this.personalInfo = personalInfo;
            this.IdNumber = IdNumber;
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - birthYear;
            }
        }
        protected internal void HasLivedHalfOfLife() { }
        public static bool operator ==(MyAccessModifiers obj1, MyAccessModifiers obj2)
        {
            return (obj1.Name == obj2.Name && obj1.Age == obj2.Age && obj1.personalInfo == obj2.personalInfo);
        }
        public static bool operator !=(MyAccessModifiers obj1, MyAccessModifiers obj2) => !(obj1 == obj2);

        public override bool Equals(object obj)
        {
            return obj is MyAccessModifiers modifiers &&
                   personalInfo == modifiers.personalInfo &&
                   Name == modifiers.Name &&
                   Age == modifiers.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(personalInfo, Name, Age);
        }
    }
}
