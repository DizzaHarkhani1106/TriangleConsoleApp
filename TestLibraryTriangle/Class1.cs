using NUnit.Framework;
using ConsoleTriangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibraryTriangle
{
   
        [TestFixture]
        public class Class1
        {
            [Test]
            public void ValidTriangle_Input60and60_OutputValidTriangle()
            {
                //Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;

                string expected = "The triangle is valid.";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.That(expected, Is.EqualTo(actual));
            }

        }
    }



