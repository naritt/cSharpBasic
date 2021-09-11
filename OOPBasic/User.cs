using System;

namespace OOPBasic
{
    public class User
    {
        // constructor method
        public User()
        {
        }

        #region Fields

        #endregion

        #region Properties
        public string fullname { get; set; }
        public string yearofbirth { get; set; }
        public int age { get { return calculateAge(); } }
        #endregion


        #region Method
        private int calculateAge()
        {
            int currentyear = DateTime.Now.Year + 543;
            int yearofbirth = Convert.ToInt32(this.yearofbirth);
            int age = currentyear - yearofbirth;
            return age;
        }
        #endregion
    }
}
