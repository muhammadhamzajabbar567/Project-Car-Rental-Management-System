using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CAR_RENTAL_MANAGEMENT_SYSTEM
{
    abstract class RentalRegistry
    {
        public abstract int mul(int x, int y);
        public abstract int mul(int x, int y, int z);

    }

     class HOURLYRENTALREGISTRY : RentalRegistry
    {
        public override int mul(int hours, int amount)
        {
            return hours * amount;
        }
        public override int mul(int hours, int amount, int discount)
        {
            return hours * amount / discount;
        }


    }
     class WEEKLYRENTALREGISTRY : RentalRegistry
    {
        public override int mul(int WEEKS, int amount)
        {
            return WEEKS * amount;
        }
        public override int mul(int WEEKS, int amount,int discount)
        {
            return WEEKS * amount / discount;
        }

    }

     class MONTLYRENTALREGISTRY : RentalRegistry
    {
        public override int mul(int Months, int amount)
        {
            return Months * amount;
        }

        public override int mul(int Months, int amount,int discount)
        {
            return Months * amount/discount;
        }
    }
}

