namespace FactorialService.Tests;

using FactorialLibrary;


public class FactorialServiceTests
    {
        [Fact]
        public void Factorial_Zero_ReturnsOne()
        {
            var result = FactorialService.Factorial(0);

            Assert.Equal(1, result);
        }

      
      [Fact]
public void Test_negative()
{
  Assert.Throws<InvalidOperationException>(()=>{
    var result = FactorialService.Factorial(-1);
  });
        }
    }