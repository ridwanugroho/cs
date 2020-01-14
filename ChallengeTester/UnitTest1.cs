using System;
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
            Assert.Equal(3, tes_str_length.countString("aku"));
        }
    }
}
