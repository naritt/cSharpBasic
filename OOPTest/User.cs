using System;

namespace OOPTest
{
    public class User
    {
        public User()
        {
        }

        // properties
        public string name { get; set; }
        public string yearofbirth { get; set; }
        public int age { get { return calAge(); } }

        // method
        private int calAge()
        {
            int currentyear = DateTime.Now.Year + 543;
            int age = currentyear - Convert.ToInt32(this.yearofbirth);
            return age;
        }
    }
}
