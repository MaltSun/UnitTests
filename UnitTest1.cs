using LibraryLab1;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;
using Moq;

namespace TestLab1
{
    public class UnitTest1
    {
        [Fact]
        public void CheckValue_ValidTour_ShouldReturnTrue()
        {
            Tour tour = new Tour(5, 10, 20, 100, 5);

            bool result = LibraryLab1.Program.CheckValue(tour);

            Assert.True(result);
        }


        [Fact]
        public void CheckValue_TourNumberMiddle_ShouldReturnTrue()
        {
           Tour tour = new Tour(25, 10, 20, 100, 5);

            bool result = LibraryLab1.Program.CheckValue(tour);
            Assert.True(result);
        }
       
        [Fact]
        public void CheckValue_TourNegativeNumberOutOfRange_ShouldThrowArgumentOutOfRangeException()
        {
          
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => new Tour(0, 10, 20, 100, 5));

            Assert.Equal("tourNumber", exception.ParamName);

            Assert.Contains("Количество туров должно быть от 1 до 50.", exception.Message);
        }
        [Fact]
        public void CheckValue_ToureNumbeLowBorder_ShouldReturnTrue()
        {

            Tour tour = new Tour(1, 10, 20, 100, 5);


            bool result = LibraryLab1.Program.CheckValue(tour);
            Assert.True(result);
        }

        [Fact]
        public void CheckValue_ToureNumbeHightBorder_ShouldReturnTrue()
        {

            Tour tour = new Tour(50, 10, 20, 100, 5);

            bool result = LibraryLab1.Program.CheckValue(tour);
            Assert.True(result);
        }



        [Fact]
        public void CheckValue_ReturnPercentOutOfRange_ShouldReturnFalse()
        {
            Tour tour = new Tour(5, 101, 20, 100, 5);

            bool result = LibraryLab1.Program.CheckValue(tour);

            Assert.False(result);
        }
        [Fact]
        public void CheckValue_ReturnPercentOutOfRangeNegative_ShouldReturnFalse()
        {
            Tour tour = new Tour(5, -0.1, 20, 100, 5);

            bool result = LibraryLab1.Program.CheckValue(tour);

            Assert.False(result);
        }
        [Fact]
        public void CheckValue_ReturnPercentLowBorder_ShouldReturnTrue()
        {
            Tour tour = new Tour(5, 0, 20, 100, 5);

            bool result = LibraryLab1.Program.CheckValue(tour);

            Assert.True(result);
        }
        [Fact]
        public void CheckValue_ReturnPercentHightBorder_ShouldReturnTrue()
        {
            Tour tour = new Tour(5, 100, 20, 100, 5);

            bool result = LibraryLab1.Program.CheckValue(tour);

            Assert.True(result);
        }
        [Fact]
        public void CheckValue_ReturnPercentMiddle_ShouldReturnTrue()
        {
            Tour tour = new Tour(5, 50, 20, 100, 5);

            bool result = LibraryLab1.Program.CheckValue(tour);

            Assert.True(result);
        }




        //[Fact]
        //public void CheckValue_NegativeReturnPercentOutOfRange_ShouldReturnFalse()
        //{
        //    Tour tour = new Tour(5, -10, 20, 100, 5);

        //    bool result = LibraryLab1.Program.CheckValue(tour);

        //    Assert.False(result);
        //}

        [Fact]
        public void CheckValue_OverheadsPercentOutOfRange_ShouldReturnFalse()
        {
            Tour tour = new Tour(5, 10, 101, 100, 5);

            bool result = LibraryLab1.Program.CheckValue(tour);

            Assert.False(result);
        }

        [Fact]
        public void CheckValue_NegativeOverheadsPercentOutOfRange_ShouldReturnFalse()
        {
            Tour tour = new Tour(5, 10, -0.1, 100, 5);

            bool result = LibraryLab1.Program.CheckValue(tour);
                                                                                                                                                                                                                                
            Assert.False(result);
        }
        [Fact]
        public void CheckValue_OverheadsPercentLowBorder_ShouldReturnTrue()
        {
            Tour tour = new Tour(5, 10, 0, 100, 5);

            bool result = LibraryLab1.Program.CheckValue(tour);

            Assert.True(result);
        }
        [Fact]
        public void CheckValue_NegativeOverheadsPercentHightBorder_ShouldReturnTrue()
        {
            Tour tour = new Tour(5, 10, 100, 100, 5);

            bool result = LibraryLab1.Program.CheckValue(tour);

            Assert.True(result);
        }
        [Fact]
        public void CheckValue_NegativeOverheadsPercentMiddle_ShouldReturnTrue()
        {
            Tour tour = new Tour(5, 10, 50, 100, 5);

            bool result = LibraryLab1.Program.CheckValue(tour);

            Assert.True(result);
        }





        [Fact]
        public void CheckValue_DiscountPercentOutOfRange_ShouldReturnFalse()
        {
            Tour tour = new Tour(5, 10, 20, 100, 100.1);

            bool result = LibraryLab1.Program.CheckValue(tour);

            Assert.False(result);
        }

        [Fact]
        public void CheckValue_NegativeDiscountPercentOutOfRange_ShouldReturnFalse()
        {
            Tour tour = new Tour(5, 10, 20, 100, -0.1);

            bool result = LibraryLab1.Program.CheckValue(tour);

            Assert.False(result);
        }
        [Fact]
        public void CheckValue_DiscountPercentLowBorder_ShouldReturnTrue()
        {
            Tour tour = new Tour(5, 10, 20, 100, 0);

            bool result = LibraryLab1.Program.CheckValue(tour);

            Assert.True(result);
        }
        [Fact]
        public void CheckValue_DiscountPercentHightBorder_ShouldReturnTrue()
        {
            Tour tour = new Tour(5, 10, 20, 100, 100);

            bool result = LibraryLab1.Program.CheckValue(tour);

            Assert.True(result);
        }
        [Fact]
        public void CheckValue_DiscountPercentMiddle_ShouldReturnTrue()
        {
            Tour tour = new Tour(5, 10, 20, 100, 50);

            bool result = LibraryLab1.Program.CheckValue(tour);

            Assert.True(result);
        }

        //[Fact]
        //public void GetTotalRevenue_ValidData_ShouldReturnCorrectTotal()
        //{
        //    double[] prices = { 100.0, 150.0, 200.0 };
        //    int[] vouchers = { 1, 2, 3 };

        //    Tour tour = new Tour(5, 10, 20, 100, 5);

        //    tour.TourPrice = prices;
        //    tour.TravelVoucher = vouchers;

        //    var budget = new Budget(tour);

        //    double result = budget.GetTotalRevenue(tour);

        //    double expectedRevenue = (100.0 * 1) + (150.0 * 2) + (200.0 * 3);
        //    Assert.Equal(expectedRevenue, result);
        //}

        [Fact]
        public void GetTotalRefund_ValidData_ShouldReturnCorrectTotal()
        {
            double[] prices = { 100.0, 150.0, 200.0 };
            int[] vouchers = { 1, 2, 3 };

            Tour tour = new Tour(5, 10, 20, 100, 5);

            tour.TourPrice = prices;
            tour.TravelVoucher = vouchers;

            var budget = new Budget(tour);

            double result = budget.GetTotalRefund(tour);


            double expectedRevenue = ((100.0 * 1) + (150.0 * 2) + (200.0 * 3)) * 0.1;
           
            Assert.Equal(expectedRevenue, result);
        }

        [Fact]
        public void GetNetRevenue_ValidData_ShouldReturnCorrectTotal()
        {
            double[] prices = { 100.0, 150.0, 200.0 };
            int[] vouchers = { 1, 2, 3 };

            Tour tour = new Tour(5, 10, 20, 100, 5);

            tour.TourPrice = prices;
            tour.TravelVoucher = vouchers;

            var budget = new Budget(tour);

            double result = budget.GetNetRevenue(tour);
            double expectedRevenue = ((100.0 * 1) + (150.0 * 2) + (200.0 * 3)) - (((100.0 * 1) + (150.0 * 2) + (200.0 * 3)) * 0.1);

            Assert.Equal(expectedRevenue, result);
        }

        [Fact]
        public void GetTotalExpenses_ValidData_ShouldReturnCorrectTotal()
        {
            double[] prices = { 100.0, 150.0, 200.0 };
            int[] vouchers = { 1, 2, 3 };

            Tour tour = new Tour(5, 10, 20, 100, 5);

            tour.TourPrice = prices;
            tour.TravelVoucher = vouchers;

            var budget = new Budget(tour);

            double result = budget.GetTotalExpenses(tour);

            
            double expectedTotalExpenses = ((100.0 * 1) + (150.0 * 2) + (200.0 * 3)) * 0.2 + 100;

            Assert.Equal(expectedTotalExpenses, result);
        }

        [Fact]
        public void GetFinalBalance_ValidData_ShouldReturnCorrectTotal()
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
            double[] prices = { 100.0, 150.0, 200.0 };
            int[] vouchers = { 1, 2, 3 };

            Tour tour = new Tour(5, 10, 20, 100, 5);

            tour.TourPrice = prices;
            tour.TravelVoucher = vouchers;

            var budget = new Budget(tour);

            double result = budget.GetFinalBalance(tour);

            double NetRevenue = ((100.0 * 1) + (150.0 * 2) + (200.0 * 3)) - (((100.0 * 1) + (150.0 * 2) + (200.0 * 3)) * 0.1);
            double expectedFinalBalance = NetRevenue - ((((100.0 * 1) + (150.0 * 2) + (200.0 * 3)) * 0.2) + 100);

            Assert.Equal(expectedFinalBalance, result);
        }

        [Fact]
        public void GetSalaseBalance_ValidData_ShouldReturnCorrectTotal()
        {
            double[] prices = { 100.0, 150.0, 200.0 };
            int[] vouchers = { 1, 2, 3 };

            Tour tour = new Tour(5, 10, 20, 100, 5);

            tour.TourPrice = prices;
            tour.TravelVoucher = vouchers;

            var budget = new Budget(tour);

            double result = budget.GetSalesBalance(tour);

            double NetRevenue = ((100.0 * 1) + (150.0 * 2) + (200.0 * 3)) - (((100.0 * 1) + (150.0 * 2) + (200.0 * 3)) * 0.1);
            double finalBalance = NetRevenue - ((((100.0 * 1) + (150.0 * 2) + (200.0 * 3)) * 0.2) + 100);
            double expectedDiscountBalance = finalBalance - (finalBalance *  0.05);

            Assert.Equal(expectedDiscountBalance, result);
        }

        [Fact]
        public void GetTotalRevenue_NegativeTourPrice_ShouldReturnZero()
        {
            Tour tour = new Tour(3, 10, 20, 100, 5)
            {
                TourPrice = new double[] { -100.0, 150.0, 200.0 },
                TravelVoucher = new int[] { 1, 2, 3 }
            };

            var budget = new Budget(tour);
            double result = budget.GetTotalRevenue(tour);

            Assert.Equal(0, result);
        }

        [Fact]
        public void GetTotalRevenue_NegativeTravelVoucher_ShouldReturnZero()
        {
            Tour tour = new Tour(3, 10, 20, 100, 5)
            {
                TourPrice = new double[] { 100.0, 150.0, 200.0 },
                TravelVoucher = new int[] { -1, 2, 3 }
            };

            var budget = new Budget(tour);
            double result = budget.GetTotalRevenue(tour);

            Assert.Equal(0, result);
        }

        [Fact]
        public void GetTotalRefund_NegativeTourPrice_ShouldReturnZero()
        {
            Tour tour = new Tour(3, 10, 20, 100, 5)
            {
                TourPrice = new double[] { -100.0, 150.0, 200.0 },
                TravelVoucher = new int[] { 1, 2, 3 }
            };

            var budget = new Budget(tour);
            double result = budget.GetTotalRefund(tour);

            Assert.Equal(0, result);
        }

        [Fact]
        public void GetTotalRefund_NegativeTravelVoucher_ShouldReturnZero()
        {
            Tour tour = new Tour(3, 10, 20, 100, 5)
            {
                TourPrice = new double[] { 100.0, 150.0, 200.0 },
                TravelVoucher = new int[] { -1, 2, 3 }
            };

            var budget = new Budget(tour);
            double result = budget.GetTotalRefund(tour);

            Assert.Equal(0, result);
        }

        [Fact]
        public void GetNetRevenue_NegativeTourPrice_ShouldReturnZero()
        {
            Tour tour = new Tour(3, 10, 20, 100, 5)
            {
                TourPrice = new double[] { -100.0, 150.0, 200.0 },
                TravelVoucher = new int[] { 1, 2, 3 }
            };

            var budget = new Budget(tour);
            double result = budget.GetNetRevenue(tour);

            Assert.Equal(0, result);
        }

        [Fact]
        public void GetTotalExpenses_NegativeTourPrice_ShouldReturnZero()
        {
            Tour tour = new Tour(3, 10, 20, 100, 5)
            {
                TourPrice = new double[] { -100.0, 150.0, 200.0 },
                TravelVoucher = new int[] { 1, 2, 3 }
            };

            var budget = new Budget(tour);
            double result = budget.GetTotalExpenses(tour);

            Assert.Equal(0, result);
        }

    }

}
