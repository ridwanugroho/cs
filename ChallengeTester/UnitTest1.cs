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
            Assert.Equal(373.15, Temperature.CelciusToKelvin(100));
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
        public void tes_kalkulator()
        {
            Assert.Equal(15, Calculator.Sum(7, 8));
            Assert.Equal(7, Calculator.Substract(15, 8));
            Assert.Equal(100, Calculator.Multiply(25, 4));
            Assert.Equal(11, Calculator.Divide(22, 2));
        }

        [Fact]
        public void tes_sum()
        {
            int[] raw = {1, 5, 8, 3};
            Assert.Equal(17, SumArgs.sum(raw));
        }
    
        [Fact]
        public void tes_string_to_uppercase()
        {
            var expected = "AKU ADALAH SEORANG PELAUT";

            Assert.Equal(expected, Upper.toUpper("aku Adalah seoRang pelauT"));
        }
    
        [Fact]
        public void tes_penghitung_jumlah_kata()
        {
            Assert.Equal(4, CountWords.countWords("aku adalah anak gebala"));
            Assert.Equal(1, CountWords.countWords("aaaaassss"));
        }
    
        [Fact]
        public void tes_detektor_palindrome()
        {
            Assert.True(PalindromeDetector.IsPalindrome("akuka"));
            Assert.False(PalindromeDetector.IsPalindrome("akukaa"));
        }
    
        [Fact]
        public void tes_mirror_string()
        {
            string expected = "---11100111---";
            Assert.Equal(expected, MirrorString.Mirror("---1110"));
        }

        [Fact]
        public void tes_index_finder()
        {
            string[] fruits = {
                "Jeruk",
                "Apel",
                "Anggur",
                "Pepaya",
                "Pisang",
                "Kiwi",
                "Markisa",
            };

            Assert.Equal(0, FruitFinder.IndexFinder(fruits, "Jeruk"));
            Assert.Equal(3, FruitFinder.IndexFinder(fruits, "Pepaya"));
            Assert.Equal(6, FruitFinder.IndexFinder(fruits, "Markisa"));
        }
    
        [Fact]
        public void tes_foo_bar_buz()
        {
            var expected = new ArrayList();
            for(int i=0; i<1000; i++){
                if(i%5 == 0){
                    if(i%20 == 0){
                        if(i%100 == 0)
                            expected.Add("Baz");

                        else
                            expected.Add("Bar");
                    }

                    else
                        expected.Add("Foo");
                }

                else
                    expected.Add(i);
            }

            Assert.Equal(expected, FooBarBaz.generator());
        }
    
        [Fact]
        public void tes_find_min_max_avg()
        {
            int[] numbers = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};
            Assert.Equal(330, FindMinMaxAvg.FindMax(numbers));
            Assert.Equal(-65, FindMinMaxAvg.FindMin(numbers));
            Assert.Equal(52.17, FindMinMaxAvg.FindAverage(numbers));
        }

        [Fact]
        public void tes_sorting()
        {
            int[] expected = {-65, -4, 2, 4, 12, 19, 40, 54, 54, 88, 92, 330};
            int[] raw = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};

            Assert.Equal(expected, Sorter.sort(raw));
        }
    
        [Fact]
        public void tes_class_obj()
        {
            string expected = "Indomie Goreng (Rp 2800)";
            Item.name = "Indomie Goreng";
            Item.price = 3500;
            Item.onSale = true;

            Assert.Equal(expected, Item.testPrint());
        }
    }
}
