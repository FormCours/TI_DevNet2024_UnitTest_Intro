using Demo_Test_01.CustomExceptions;
using Demo_Test_01.Utils;

namespace Demo_Test_01.Test.Utils
{
    public class MathUtilsTest
    {
        #region Addition
        [Fact]
        public void Addition_DeuxEntier()
        {
            // Arrange (Préparation)
            const int nb1 = 5;
            const int nb2 = 3;
            const int expected = 8;

            // Action (Code à tester)
            int actual = MathUtils.Addition(nb1, nb2);

            // Assert (Validation)
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Addition_PlusieurEntier()
        {
            // Arrange
            const int nb1 = 61;
            const int nb2 = 22;
            const int nb3 = -5;
            const int nb4 = 7;
            const int expected = 85;

            // Action
            int actual = MathUtils.Addition(nb1, nb2, nb3, nb4);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Addition_DeuxReel()
        {
            // Arrange
            const double nb1 = 1.5;
            const double nb2 = 0.5;
            const double expected = 2;

            // Action
            double actual = MathUtils.Addition(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Addition_DeuxReel_ErreurIEEE754()
        {
            // Arrange
            const double nb1 = 0.1;
            const double nb2 = 0.2;
            const double expected = 0.3;

            // Action
            double actual = MathUtils.Addition(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Addition_PlusieurReel()
        {
            // Arrange
            const double nb1 = 0.7;
            const double nb2 = 0.1;
            const double nb3 = 0.8;
            const double nb4 = -0.2;
            const double nb5 = -0.8;
            const double expected = 0.6;

            // Action
            double actual = MathUtils.Addition(nb1, nb2, nb3, nb4, nb5);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Addition_DeuxEntier_ErreurDeDepassement()
        {
            // Arrange
            const int nb1 = 1_200_000_000;
            const int nb2 = 2_100_000_000;

            // Action + Assert
            Assert.Throws<MathUtilsException>(() =>
            {
                MathUtils.Addition(nb1, nb2);
            });
        }

        [Fact]
        public void Addition_PlusieurEntier_ErreurDeDepassement()
        {
            // Arrange
            const int nb1 = 1;
            const int nb2 = 2_100_000_000;
            const int nb3 = 500_000_000;

            // Action + Assert
            Assert.Throws<MathUtilsException>(() =>
            {
                MathUtils.Addition(nb1, nb2, nb3);
            });
        }

        #endregion

        #region Soustraction
        [Theory]
        [InlineData(10, 2, 8)]
        [InlineData(5, -5, 10)]
        [InlineData(-2, -2, 0)]
        [InlineData(-9, 7, -16)]
        public void Soustraction_DeuxEntier(int nb1, int nb2, int expected)
        {
            // Arrange ?

            // Action
            int actual = MathUtils.Soustraction(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }


        public static IEnumerable<object[]> dataSoustractionDouble = new List<object[]>
        {
            new object[] { 1.8, 0.3, 1.5 },
            new object[] { 2.0, 1.0, 1.0 },
            new object[] { 0.3, 0.1, 0.2 }
        };

        [Theory]
        [MemberData(nameof(dataSoustractionDouble))]
        public void Soustraction_DeuxReel(double nb1, double nb2, double expected)
        {
            // Action
            double actual = MathUtils.Soustraction(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Divison
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(6, 2, 3)]
        [InlineData(4, -2, -2)]
        [InlineData(5, 3, 1)]
        public void Division_DeuxEntier(int nb1, int nb2, int expected)
        {
          
            // Action
            int actual = MathUtils.Division(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Division_DeuxEntier_DivisionByZero()
        {
            // Arrange
            const int nb1 = 5;
            const int nb2 = 0;

            // Action + Assert
            Assert.Throws<MathUtilsDivByZeroException>(() =>
            {
                MathUtils.Division(nb1, nb2);
            });
        }
        #endregion

        #region Multi
        [Theory]
        [InlineData(5, 2, 10)]
        [InlineData(-2, 3, -6 )]
        [InlineData(-9, -3, 27 )]
        public void Multiplication_DeuxEntier(int nb1, int nb2, int expected)
        {

            // Action
            int actual = MathUtils.Multiplication(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiplication_DeuxEntier_Overflow()
        {
            const int nb1 = 5_000_000;
            const int nb2 = 1_000;

            Assert.Throws<MathUtilsException>(() =>
            {
                int result = MathUtils.Multiplication(nb1, nb2);
            });
        }

        [Theory]
        [InlineData(1.5, 1.5, 2.25)]
        [InlineData(0.1, -0.1, -0.01)]

        public void Multiplication_DeuxReel(double nb1, double nb2, double expected)
        {
            //Action
            double actual = MathUtils.Multiplication(nb1, nb2);

            //Assert
            Assert.Equal(expected, actual);
        }
        #endregion
    }
}
