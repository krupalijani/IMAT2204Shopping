using System.Collections.Generic;
using System;





namespace clsproduct
{
    public class clsProductCollection
    {

        //private data member for list
        List<clsProduct> mProductList = new List<clsProduct>();



        public List<clsProduct> ProductList
        {

            get
            {
                //return private data
                return mProductList;

            }

            set
            {
                //set private data
                mProductList = value;
            }


        }


        public int Count
        {



            get
            {
                return mProductList.Count;
            }


            set
            {
                //lateron

            }








        }

        public clsProduct ThisProduct { get; set; }






        public clsProductCollection()
        {
            //VAR for index
            int index = 0;
            //var to store the record count
            int RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_SelectALL");
            //get the count of records
            RecordCount = DB.Count;
            //while loop
            while (index < RecordCount)
            {
                //create a blank address
                clsProduct AProduct = new clsProduct();
                //read the fields from the current record
          
                AProduct.ProductActive = Convert.ToBoolean(DB.DataTable.Rows[index]["ProductActive"]);
                AProduct.ProductID = Convert.ToInt32(DB.DataTable.Rows[index]["ProductID"]);
                AProduct.ProductName = Convert.ToString(DB.DataTable.Rows[index]["ProductName"]);
                AProduct.ProductPrice = Convert.ToDecimal(DB.DataTable.Rows[index]["ProductPrice"]);
                AProduct.ProductQuantity = Convert.ToInt32(DB.DataTable.Rows[index]["ProductQuantity"]);
                mProductList.Add(AProduct);
                index++;
            }


        }

    }
}

