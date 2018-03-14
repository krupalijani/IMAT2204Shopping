using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using clsproduct;
using System.Collections.Generic;


namespace tstproduct
{
    [TestClass]//
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //test to see that it exists
            Assert.IsNotNull(AllProducts);
        }


        [TestMethod]
        public void ProductListOK()
        {
            // create instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsProduct> TestList = new List<clsProduct>();
            //add an itrem to the list
            //create the item of the test data
            clsProduct TestItem = new clsProduct();
            // set its properties
            TestItem.ProductActive = true;
            TestItem.ProductID = 3;
            TestItem.ProductName = "lenovo11";
            TestItem.ProductPrice = (decimal)10.20;
            TestItem.ProductQuantity = 1;
            // add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that 2 values are same
            Assert.AreEqual(AllProducts.ProductList, TestList);

        }






        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    // create instance of the class we want to create
        //    clsProductCollection AllProducts = new clsProductCollection();
        //    //create some test data to assign to the property
        //    //in this case data needs to be a list of objects
        //    List<clsProduct> TestList = new List<clsProduct>();
        //    //add an itrem to the list
        //    //create the item of the test data
        //    clsProduct TestItem = new clsProduct();
        //    // set its properties
        //    TestItem.Active = true;
        //    TestItem.ProductID = 3;
        //    TestItem.ProductName = "lenovo11";
        //    TestItem.ProductPrice = (decimal)10.20;
        //    TestItem.ProductQuantity = 1;
        //    // add the item to the test list
        //    TestList.Add(TestItem);
        //    //assign the data to the property
        //    AllProducts.ProductList = TestList;
        //    //test to see that 2 values are same
        //    Assert.AreEqual(AllProducts.Count, TestList.Count);

        //}






        [TestMethod]
        public void ThisProductPropertyOK()
        {
            // create instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            clsProduct TestProduct = new clsProduct();
            // set its properties
            TestProduct.ProductActive = true;
            TestProduct.ProductID = 3;
            TestProduct.ProductName = "lenovo11";
            TestProduct.ProductPrice = (decimal)10.20;
            TestProduct.ProductQuantity = 1;
           //assign the data to the property
            AllProducts. ThisProduct = TestProduct;
            //test to see that 2 values are same
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);

        }



        [TestMethod]
        public void ListAndCOuntOK()
        {
            // create instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsProduct> TestList = new List<clsProduct>();
            //add an itrem to the list
            //create the item of the test data
            clsProduct TestItem = new clsProduct();
            // set its properties
            TestItem.ProductActive = true;
            TestItem.ProductID = 3;
            TestItem.ProductName = "lenovo11";
            TestItem.ProductPrice = (decimal)10.20;
            TestItem.ProductQuantity = 1;
            // add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that 2 values are same
            Assert.AreEqual(AllProducts.Count, TestList.Count);

        }



        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    // create instance of the class we want to create
        //    clsProductCollection AllProducts = new clsProductCollection();
        //    //test to see that it exists
        //    Assert.AreEqual(AllProducts.Count, 2);
        //}

















    }
}
