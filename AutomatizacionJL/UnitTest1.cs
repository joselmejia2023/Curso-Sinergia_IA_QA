namespace AutomatizacionJL
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        public int add(int x, int y)
            
        {
            return x + y;
        }

        public bool MayorA5(int valor)
        {
            if (valor > 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        [Fact]
        public void TestCorrecto1()
        {
            Assert.Equal(4, add(2, 2));
        }
        [Fact]
        public void TestCorrecto2()
        {
            Assert.NotEqual(5, add(2, 2));
        }


        [Theory]
        [InlineData(3)]
        [InlineData(100)]
        [InlineData(6)]
        public void TestCorrectoTheory(int value)
        {
            Assert.True(MayorA5(value));
        }

    }
}