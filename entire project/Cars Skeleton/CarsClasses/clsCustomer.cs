using System;

namespace CarsClasses
{
    public class clsCustomer
    {
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        private Int32 mCustomerID;
        public int CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property 
                mCustomerID = value;
            }
        }

        private String mFullName;
        public string FullName
        {
            get
            {
                return mFullName;
            }
            set
            {
                mFullName = value;
            }
        }

        private String mEmail;
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        private Int64 mMobileNumber;
        public long MobileNumber
        {
            get
            {
                return mMobileNumber;
            }
            set
            {
                mMobileNumber = value;
            }
        }

        private String mAddress;
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        private bool mLoyaltyDiscount;
        public bool LoyaltyDiscount
        {
            get
            {
                return mLoyaltyDiscount;
            }
            set
            {
                mLoyaltyDiscount = value;
            }
        }

        public bool Find(int customerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add a parameter for the customer ID search
            DB.AddParameter("@CustomerID", customerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomerRecords_FilterByCustomerID");
            //If one record is found there should be wither one or zero
            if (DB.Count == 1)
            {
                //copy the data from database to private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mMobileNumber = Convert.ToInt64(DB.DataTable.Rows[0]["MobileNumber"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mLoyaltyDiscount = Convert.ToBoolean(DB.DataTable.Rows[0]["LoyaltyDiscount"]);
                //return that everything worked ok
                return true;

            }
            //if no record was found
            else
            {
                return false;
            }
        }

    }
}