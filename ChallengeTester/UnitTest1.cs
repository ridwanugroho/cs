using System;
using System.Collections;
using Xunit;
using Challenge;

namespace ChallengeTester
{
    public class UnitTest1
    {
        [Fact]
        public void tes_input_nama()
        {
            Assert.Equal("ridwan", Program.nama("ridwan"));
        }

        [Fact]
        public void tes_day_to_next_birthday()
        {
            Assert.Equal(68, DaysToNextBirthday.test("2020/03/23"));
        }

        [Fact]
        public void tes_str_length()
        {
            // Assert.Equal(3, StrLength.countString("aku"));
        }

        [Fact]
        public void tes_subtitusi_dolorDuoImperdiet()
        {
            var raw = "aku adalah bumi dan langit";
            var expected = "aku adalah **** dan ******";
            var censorer = new ArrayList();
            censorer.Add("langit");
            censorer.Add("bumi");
            Assert.Equal(expected, Subtitute.replace(raw, censorer));
        }
    
        [Fact]
        public void tes_even_odd()
        {
            Assert.True(EvenOdd.isOdd(5));
            Assert.False(EvenOdd.isOdd(6));
            Assert.True(EvenOdd.isEven(6));
            Assert.False(EvenOdd.isEven(5));
            
        }

        [Fact]
        public void tes_grade_nilai()
        {
            Assert.Equal('A', Grade.grading(99));
            Assert.Equal('B', Grade.grading(88));
            Assert.Equal('C', Grade.grading(77));
            Assert.Equal('D', Grade.grading(66));
            Assert.Equal('E', Grade.grading(22));
        }

        [Fact]
        public void tes_temperatur_converter()
        {
            Assert.Equal(32, Temperature.CelciusToFahrenheit(0));
            Assert.Equal(10, Temperature.FahrenheitToCelcius(50));
            Assert.Equal(375.15, Temperature.CelciusToKelvin(100));
            Assert.Equal(101.85, Temperature.KelvinToCelcius(375));
            Assert.Equal(215.33, Temperature.KelvinToFahrenheit(375));
            Assert.Equal(262.039, Temperature.FahrenheitToKelvin(12));
        }

        [Fact]
        public void tes_leap_year()
        {
            Assert.True(LeapYear.isLeapYear(2020));
            Assert.False(LeapYear.isLeapYear(2021));
        }

        [Fact]
        public void tes_timezone_gap()
        {
            var jakarta = Tuple.Create("Jakarta", 7);
            var bali = Tuple.Create("Bali", 8);
            var expected1 = $"{bali.Item1} 1 hour ahead {jakarta.Item1}";
            var expected2 = $"{jakarta.Item1} 1 hour behind {bali.Item1}";
            
            Assert.Equal(expected1, Timezone.TimezoneDiff(bali, jakarta));
            Assert.Equal(expected2, Timezone.TimezoneDiff(jakarta, bali));
        }

        [Fact]
        public void TestName()
        {
            Assert.Equal(15, Calculator.Sum(7, 8));
            Assert.Equal(7, Calculator.Substract(15, 8));
            Assert.Equal(100, Calculator.Multiply(25, 4));
            Assert.Equal(11, Calculator.Divide(22, 2));
        }
    }
}
