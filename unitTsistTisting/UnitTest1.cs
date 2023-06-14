using Unit_Testing;

namespace unitTsistTisting
{
    public class UnitTest1
    {
        [Fact]
        public void Firstcase()
        {
         
                decimal b = 9;

               decimal result= Program.Deposit(b);

                Assert.Equal(19, result);
 
        }
        [Fact]
        public void secondcase()
        {

            decimal b = 9;

            decimal result = Program.Withdraw(b);

            Assert.Equal(1, result);

        }


    }
}