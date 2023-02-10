using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TestClass

{
    [TestFixture]

    public class Class1
    {
        Triangle triangle =  new Triangle();

        [Test]

        public void AnalyzeTriangle_Input60and60and60_OutputEquilateralTriangle()
        {
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";


            string actual = triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);


            Assert.AreEqual(expected, actual);

        }


        [Test]
        //input 값이 다르니 상과 무
        public void AnalyzeTriangle_Input60and60and35_OutputisoscelesTriangle()
        {
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 35;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";


            string actual = triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);


            Assert.AreEqual(expected, actual);

        }




    }
}