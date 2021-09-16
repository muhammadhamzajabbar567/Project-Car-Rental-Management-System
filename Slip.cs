using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CAR_RENTAL_MANAGEMENT_SYSTEM
{
    public class Slip
    {
        public int RentalRegistryNumber = 0;
        public int Amount = 0;

        public int RRG
        {
            get
            {
                return RentalRegistryNumber;
            }

            set
            {
                RentalRegistryNumber = value;
            }
        }

        public int amount
        {
            get
            {

                return Amount;

            }

            set
            {

                Amount = value;

            }

        }


        public void GenerateBill()
        {
            MessageBox.Show("Your Registeration no is:  " + RentalRegistryNumber + "\n Your Total Amount is:" + Amount);  
        }

    }
}
