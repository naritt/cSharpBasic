using System;

namespace OOPBasic
{
    public class Vaccine
    {
        // constructor method
        public Vaccine()
        {
        }

        #region Fields

        #endregion

        #region Properties
        public string name { get; set; }
        public int stock { get; set; }
        #endregion

        #region Method
        public void reserveVaccine(int reserve)
        {
            this.stock = this.stock - reserve;
            if (this.stock < 0)
            {
                throw new Exception("not enough stock");
            }
        }
        #endregion
    }
}
