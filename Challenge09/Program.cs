using System;

namespace Timezone
{
    class Program
    {
        static void Main(string[] args)
        {
            var jakarta = Tuple.Create("Jakarta", 7);
            var bali = Tuple.Create("Bali", 8);
            var london = Tuple.Create("London", 0);
            var cairo = Tuple.Create("Cairo", 2);
            var denver = Tuple.Create("Denver", -6);
            var chicago = Tuple.Create("Chicago", -5);

            TimezoneDiff(jakarta, london); // Output: Jakarta 7 hours ahead London
            TimezoneDiff(cairo, chicago); // Output: Cairo 7 hours ahead Chicago
            TimezoneDiff(cairo, bali); // Output: Cairo 6 hours behind ahead Bali
            TimezoneDiff(denver, jakarta); // Output: Denver 13 hours behind Jakarta
        }

        static string TimezoneDiff(Tuple<string, int> a, Tuple<string, int> b)
        {
            // Put your solution at here

            return "";
        }
    }
}
