using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6NoahUkura
{
    class Customers : PersonV2
    {
        private DateTime customerSince;
        private double totalPurchases;
        private bool discountMember;
        private int rewardsEarned;

        public DateTime CustomerSince
        {
            get
            {
                return customerSince;
            }
            set
            {
                if (ValidationLibrary.IsAPastDate(value))
                {
                    customerSince = value;
                }
                else
                {
                    feedback += "\nError: Please enter a past date";
                }
            }
        }
        public double TotalPurchases
        {
            get
            {
                return totalPurchases;

            }
            set
            {
                if (ValidationLibrary.ValidTPurchases(value)){
                    totalPurchases = value;
                }
                else
                {
                    feedback += "\nError: Please enter the total value of your purchases";
                }

            }
        }
        public bool DiscountMember
        {
            get
            {
                return discountMember;
            }
            set
            {
                if (ValidationLibrary.IsAMember(value))
                {
                    discountMember = value;
                }
                else
                {
                    feedback += "\nError: Please enter true or false if you are a member or not";
                }
            }
        }
        public int RewardsEarned
        {
            get
            {
                return rewardsEarned;
            }
            set
            {
                rewardsEarned = value;
            }
        }
    public Customers()
    {
        customerSince = DateTime.Now;
        totalPurchases = 0;
        discountMember = false;
        rewardsEarned = 0;
    }
    }
    
}
