using System;

namespace clsproduct
{
    public class clsProduct
    {
        private bool mProductActive;
        //private  data member for the productId property
        private Int32 mProductID;
        //private  data member for the productName property
        private string mProductName;
        //private  data member for the productPrice property
        private decimal mProductPrice;
        //private  data member for the productQuantity property
        private Int32 mProductQuantity;

        public bool ProductActive
        {
            get
            {
                return mProductActive;


            }

            set
            {
                mProductActive = value;
            }

        }


        public int ProductID

        {
            get
            {


                return mProductID;


            }


            set

            {

                mProductID = value;


            }

        }



        public string ProductName



        {



            get
            {

                return mProductName;



            }



            set
            {


                mProductName = value;


            }



        }



        public decimal ProductPrice




        {

            get


            {
                return mProductPrice;




            }





            set
            {
                mProductPrice = value;



            }


        }

        public int ProductQuantity
        {

            get


            {
                return mProductQuantity;




            }





            set
            {
                mProductQuantity = value;



            }


        }

        public bool Find(int ProductID)
        {

          /*  //mProductID = 41;
            //mProductName = "Lenovo1101101";
            //mProductPrice = (decimal)10.20;
            //mProductQuantity = 1;
            //mProductActive = true;

            //return true;
            */


            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parmeter for the address no to search for
            DB.AddParameter("@ProductID", ProductID);
            //execute the stored procedure 
            DB.Execute("sproc_tblProduct_FilterByProductID");
            //if record is found(there should be either 1 or zero)
            if (DB.Count == 1)
            {

                //copy the data from the database to the private data members
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mProductPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ProductPrice"]);
                mProductQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ProductQuantity"]);
                mProductActive = Convert.ToBoolean(DB.DataTable.Rows[0]["ProductActive"]);


                //always return true

                return true;

            }
            else
            {
                return false;


            }
        }

        public string valid(string ProductName,string ProductQuantity, string ProductPrice)
        {

            string Error = "";

            if (ProductName.Length == 0)
            {
                Error = Error + "the name cannot be left blank";
            }
            if (ProductName.Length > 50)
            {
                Error = Error + "the name has to be less than 50 characters";
            }
            if( ProductPrice.Length == 0)
            {
                Error = Error + "the price cannot be this less";
            }
            if(ProductPrice.Length > 9999999999999999.99)
            {
                Error = Error + "Too Big";
            }
            return Error;
        }
    }
}
       
    

