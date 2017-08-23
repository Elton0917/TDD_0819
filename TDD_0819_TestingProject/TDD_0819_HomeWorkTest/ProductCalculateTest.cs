using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_0819_ProductCalculate;
using System.Collections.Generic;
using ExpectedObjects;
using FluentAssertions;

namespace TDD_0819_ProductCalculateTest
{
    [TestClass]
    public class ProductCalculateTest
    {
        private List<SampleClass> getSampleData()
        {
            return new List<SampleClass>()
            {
                new SampleClass{ Id = 1 ,Cost = 1 , Revenue = 11,SellPrice =21 } ,
                new SampleClass{ Id = 2 ,Cost = 2 , Revenue = 12 ,SellPrice =22 } ,
                new SampleClass{ Id = 3 ,Cost = 3 , Revenue = 13,SellPrice =23 } ,
                new SampleClass{ Id = 4 ,Cost = 4 , Revenue = 14,SellPrice =24 } ,
                new SampleClass{ Id = 5 ,Cost = 5 , Revenue = 15,SellPrice =25 } ,
                new SampleClass{ Id = 6 ,Cost = 6 , Revenue = 16,SellPrice =26 } ,
                new SampleClass{ Id = 7 ,Cost = 7 , Revenue = 17,SellPrice =27 } ,
                new SampleClass{ Id = 8 ,Cost = 8 , Revenue = 18,SellPrice =28 } ,
                new SampleClass{ Id = 9 ,Cost = 9 , Revenue = 19,SellPrice =29 } ,
                new SampleClass{ Id = 10 ,Cost = 10 , Revenue = 20,SellPrice =30 },
                new SampleClass{ Id = 11 ,Cost = 11 , Revenue = 21,SellPrice =31 }
            };
        }



        [TestMethod]
        public void Sum_Per3count_From_Cost_With_List()
        {

            //Arrange
            var target = new ProductCalculate() {CalculationsColum = "Cost"};
            var testData = getSampleData();
            var expected = new List<int>
            {
                6,15,24,21
            };
            //Act
            var actual = target.SumFromColumPerCount(testData,3);
            
            //Assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void Sum_Per4count_From_Revenue_With_List()
        {

            //Arrange
            var target = new ProductCalculate() { CalculationsColum = "Revenue" };
            var testData = getSampleData();
            var expected = new List<int>
            {
                50,66,60
            };
            //Act
            var actual = target.SumFromColumPerCount(testData, 4);

            //Assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void Exception_With_NegativeNumber()
        {
            //Arrange
            var target = new ProductCalculate() { CalculationsColum = "Revenue" };
            var testData = getSampleData();

            //Act
            Action act = () => target.SumFromColumPerCount(testData,-1);

            //Assert
            act.ShouldThrow<Exception>();
        }

        [TestMethod]
        public void Exception_With_Colum_Not_Exist()
        {
            //Arrange
            var target = new ProductCalculate() { CalculationsColum = "ErrorColum" };
            var testData = getSampleData();

            //Act
            Action act = () => target.SumFromColumPerCount(testData, 4);

            //Assert
            act.ShouldThrow<Exception>();
        }

        [TestMethod]
        public void InputDataCount_Equal_0_Return_0()
        {

            //Arrange
            var target = new ProductCalculate() { };
            var testData = new List<SampleClass>() ;

            var expected = new List<int>
            {
                0
            };

            //Act
            var actual = target.SumFromColumPerCount(testData,0);

            //Assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }


        //[TestMethod]
        //public void Add_New_Colum()
        //{

        //    //Arrange
        //    var target = new ProductCalculate() { CalculationsColum = "HaveNoIdea" };
        //    var testData = new List<Employee>();

        //    //Act
        //    Action act = () => target.SumFromColumPerCount(testData,  4);

        //    //Assert
        //    act.ShouldNotThrow<Exception>();
        //}

        //[TestMethod]
        //public void For_Other_domainEntity()
        //{

        //    //Arrange
        //    var target = new ProductCalculate() { CalculationsColum = "HaveNoIdea" };
        //    var testData = new List<Employee>();

        //    //Act
        //    Action act = () => target.SumFromColumPerCount(testData, 4);

        //    //Assert
        //    act.ShouldNotThrow<Exception>();
        //}

        
    }
}
