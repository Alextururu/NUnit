using NUnit.Framework;
using Practices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    [TestFixture]
    public class NUnitTests
    {
        [Test]
        public void SubtractionMustReturnNotNullValue()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Subtraction(1, 2) == -1);
        }
        [Test]
        public void AdditionalMustReturnNotNullValue()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Additional(1, 2) == 3);
        }
        [Test]
        public void MiltiplicationMustReturnNotNullValue()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Miltiplication(1, 2) == 2);
        }
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(200, 10) == 20);
        }
    }
}
