using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using clsproduct;
using System.Configuration;



namespace tstproduct
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void instanceok()
        {

            clsProduct AProduct = new clsProduct();
            Assert.IsNotNull(AProduct);


        }


        [TestMethod]
        public void ActivePropertyOk()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            //create some tests to assign to the property
            Boolean TestData = true;
            //Assign data to property
            AProduct.ProductActive = TestData;
            //Test to see the two values are the same
            Assert.AreEqual(AProduct.ProductActive, TestData);

        }


        [TestMethod]
        public void IDPropertyOk()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            Int32 TestData = 1;
            AProduct.ProductID = TestData;
            Assert.AreEqual(AProduct.ProductID, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOk()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            Int32 TestData = 1;
            AProduct.ProductQuantity = TestData;
            Assert.AreEqual(AProduct.ProductQuantity, TestData);
        }

        [TestMethod]
        public void NamePropertyOk()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string TestData = "Lenovo11";
            AProduct.ProductName = TestData;
            Assert.AreEqual(AProduct.ProductName, TestData);
        }



        [TestMethod]
        public void PricePropertyOk()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            decimal TestData = (decimal)10.20;
            AProduct.ProductPrice = TestData;
            Assert.AreEqual(AProduct.ProductPrice, TestData);
        }




        [TestMethod]
        public void FindMethodOk()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some data for testing with the method
            Int32 ProductID = 3;
            //invoke the method
            Found = AProduct.Find(ProductID);
            // test to see is the method correct
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestProductIDFound()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record the data is ok
            Boolean Ok = true;
            //create some data for testing with the method
            Int32 ProductID = 3;
            //invoke the method
            Found = AProduct.Find(ProductID);
            // check the product id

            if (AProduct.ProductID != 3)
            {

                Ok = false;
            }
            Assert.IsTrue(Ok);
        }




        [TestMethod]
        public void TestProductNameFound()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record the data is ok
            Boolean Ok = true;
            //create some data for testing with the method
            Int32 ProductID = 3;
            //invoke the method
            Found = AProduct.Find(ProductID);
            // check the product name

            if (AProduct.ProductName != "Lenovo11")
            {

                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestProductPriceFound()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record the data is ok
            Boolean Ok = true;
            //create some data for testing with the method
            Int32 ProductID = 3;
            //invoke the method
            Found = AProduct.Find(ProductID);
            // check the product price

            if (AProduct.ProductPrice != (decimal)10.20)
            {

                Ok = false;
            }
            Assert.IsTrue(Ok);
        }



        [TestMethod]
        public void TestProductQuantityFound()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record the data is ok
            Boolean Ok = true;
            //create some data for testing with the method
            Int32 ProductID = 3;
            //invoke the method
            Found = AProduct.Find(ProductID);
            // check the product quantity

            if (AProduct.ProductQuantity != 1)
            {

                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            //string variable to store any erroe message
            String Error = "";

            //create some data for testing with the method

            string ProductName = "Lenovo11";
            string ProductPrice = "2";
            string ProductQuantity = "10.20";
            //invoke the method
            Error = AProduct.valid(ProductName,ProductPrice,ProductQuantity);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            //string variable to store any error message
           

            //create some data for testing with the method

            string ProductName = ""; //this should trigger the error
            string ProductQuantity = "10";
            string ProductPrice = "10.20";

            //invoke the method

            Error = AProduct.valid(ProductName, ProductQuantity, ProductPrice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            ////string variable to store any error message
            //String Error = "";

            //create some data for testing with the method

            string ProductName = "a"; //this should be ok
            string ProductQuantity = "10";
            string ProductPrice = "10.20";


            //invoke the method

            Error = AProduct.valid(ProductName, ProductQuantity, ProductPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            ////string variable to store any error message
            //String Error = "";

            //create some data for testing with the method

            string ProductName = "Ab"; //should be ok
            string ProductQuantity = "10";
            string ProductPrice = "10.20";

            //invoke the method

            Error = AProduct.valid(ProductName, ProductPrice, ProductQuantity);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            ////string variable to store any error message
            //String Error = "";

            //create some data for testing with the method

            string ProductName = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvw"; //this should trigger the error
            string ProductQuantity = "10";
            string ProductPrice = "10.20";

            //invoke the method

            Error = AProduct.valid(ProductName, ProductQuantity, ProductPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void ProductNameMax()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            ////string variable to store any error message
            //String Error = "";

            //create some data for testing with the method

            string ProductName = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwx"; //this should trigger the error
            string ProductQuantity = "10";
            string ProductPrice = "10.20";

            //invoke the method

            Error = AProduct.valid(ProductName, ProductPrice, ProductQuantity);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ProductNameMid()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            ////string variable to store any error message
            //String Error = "";

            //create some data for testing with the method

            string ProductName = "abcdefghijklmnopqrstuvwxy"; //this should trigger the error
            string ProductQuantity = "10";
            string ProductPrice = "10.20";

            //invoke the method

            Error = AProduct.valid(ProductName, ProductQuantity, ProductPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            ////string variable to store any error message
            //String Error = "";

            //create some data for testing with the method

            string ProductName = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwx"; //this should trigger the error
            string ProductQuantity = "10";
            string ProductPrice = "10.20";

            //invoke the method

            Error = AProduct.valid(ProductName, ProductPrice, ProductQuantity);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameExtreme()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string Error = "";
            ////string variable to store any error message
            //String Error = "";

            //create some data for testing with the method

            string ProductName = ""; //this should trigger the error

            ProductName = ProductName.PadRight(500, 'a');
            string ProductQuantity = "10";
            string ProductPrice = "10.20";
            //invoke the method

            Error = AProduct.valid(ProductName, ProductQuantity, ProductPrice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMinMinusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string ProductName = "Lenovo11";
            string ProductQuantity = "10";
            string ProductPrice = "-0.01";
            //string variable to store any error message
           String Error = "";

            //create some data for testing with the method
            //invoke the method

            Error = AProduct.valid(ProductName, ProductQuantity, ProductPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");

       }


        [TestMethod]
        public void ProductPriceMin()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string ProductName = "Lenovo11";
            string ProductQuantity = "10";
            string ProductPrice = "0.00";
            //string variable to store any error message
            String Error = "";

            //create some data for testing with the method
            //invoke the method

            Error = AProduct.valid(ProductName, ProductQuantity, ProductPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ProductPriceMinPlusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string ProductName = "Lenovo11";
            string ProductQuantity = "10";
            string ProductPrice = "0.01";
            //string variable to store any error message
            String Error = "";

            //create some data for testing with the method
            //invoke the method

            Error = AProduct.valid(ProductName, ProductQuantity, ProductPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductPriceMaxMinusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string ProductName = "Lenovo11";
            string ProductQuantity = "10";
            string ProductPrice = "9999999999999999.98";
            //string variable to store any error message
            String Error = "";

            //create some data for testing with the method
            //invoke the method

            Error = AProduct.valid(ProductName, ProductQuantity, ProductPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");

        }




        [TestMethod]
        public void ProductPriceMax()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string ProductName = "Lenovo11";
            string ProductQuantity = "10";
            string ProductPrice = "9999999999999999.99";
            //string variable to store any error message
            String Error = "";
            //hELLO

            //create some data for testing with the method
            //invoke the method

            Error = AProduct.valid(ProductName, ProductQuantity, ProductPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductPriceMaxplusOne()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string ProductName = "Lenovo11";
            string ProductQuantity = "10";
            string ProductPrice = "1000000000000000.00";
            //string variable to store any error message
            String Error = "";

            //create some data for testing with the method
            //invoke the method

            Error = AProduct.valid(ProductName, ProductQuantity, ProductPrice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ProductPriceMid()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string ProductName = "Lenovo11";
            string ProductQuantity = "10";
            string ProductPrice = "10000000.00";
            //string variable to store any error message
            String Error = "";

            //create some data for testing with the method
            //invoke the method

            Error = AProduct.valid(ProductName, ProductQuantity, ProductPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void ProductPriceExtremeMax()
        {
            //creates an instance of a class
            clsProduct AProduct = new clsProduct();
            string ProductName = "Lenovo11";
            string ProductQuantity = "10";
            string ProductPrice = "99999999999999999.99";
            //string variable to store any error message
            String Error = "";

            //create some data for testing with the method
            //invoke the method

            Error = AProduct.valid(ProductName, ProductQuantity, ProductPrice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");

        }







    }
}