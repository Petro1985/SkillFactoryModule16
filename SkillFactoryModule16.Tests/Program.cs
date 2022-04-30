using NUnit.Framework;
using Practices;

namespace SkillFactoryModule16
{
    [TestFixture]
    public class UserRepositoryTests 
    {
        [Test]
        public void CalculatorAdditionTest()
        {
            var calc = new Calculator();
            
            Assert.True(calc.Addition(3,4) == 7);
            Assert.True(calc.Addition(5,6) == 11);
            Assert.True(calc.Addition(-5,7) == 2);
            Assert.True(calc.Addition(1,6) == 7);
        }

        [Test]
        public void CalculatorSubtractionTest()
        {
            var calc = new Calculator();
            
            Assert.True(calc.Subtraction(8,4) == 4);
            Assert.True(calc.Subtraction(5,6) == -1);
            Assert.True(calc.Subtraction(15,7) == 8);
            Assert.True(calc.Subtraction(1,6) == -5);
        }

        [Test]
        public void CalculatorMultiplicationTest()
        {
            var calc = new Calculator();
            
            Assert.True(calc.Multiplication(8,4) == 32);
            Assert.True(calc.Multiplication(5,6) == 30);
            Assert.True(calc.Multiplication(-5,7) == -35);
            Assert.True(calc.Multiplication(1,6) == 6);
        }
        
        [Test]
        public void CalculatorDivisionTest()
        {
            var calc = new Calculator();
            
            Assert.True(calc.Division(8,4) == 2);
            Assert.True(calc.Division(5,6) == 0);
            Assert.True(calc.Division(-5,7) == 0);
            Assert.True(calc.Division(-10,6) == -1);
            Assert.Throws<DivideByZeroException>(() => calc.Division(-10,0));
        }
    }
}