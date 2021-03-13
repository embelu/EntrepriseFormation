using System;
using System.Collections.Generic;
using System.Text;

namespace Entreprise.Comparator
{
    public class TravailleurComparator
    {
        public class SortByAgeAsc : IComparer<Travailleur>
        {
            public int Compare(Travailleur x, Travailleur y)
            {
                if (x.Age > y.Age)
                {
                    return 1;
                }

                if (x.Age < y.Age)
                {
                    return -1;
                }

                return 0;
            }
        }

        public class SortByAgeDesc : IComparer<Travailleur>
        {
            public int Compare(Travailleur x, Travailleur y)
            {
                if (x.Age < y.Age)
                {
                    return 1;
                }

                if (x.Age > y.Age)
                {
                    return -1;
                }

                return 0;
            }
        }

        public class SortByAgeAndNameAsc : IComparer<Travailleur>
        {
            public int Compare(Travailleur x, Travailleur y)
            {
                int result = 0;


                if (x.Age > y.Age)
                {
                    result = 1;
                }

                if (x.Age < y.Age)
                {
                    result = -1;
                }

                if (result == 0)
                {
                    result = x.Nom.CompareTo(y.Nom);
                }

                return result;
            }
        }

        public class SortByAgeAndNameDesc : IComparer<Travailleur>
        {
            public int Compare(Travailleur x, Travailleur y)
            {
                int result = 0;

                if (x.Age < y.Age)
                {
                    result = 1;
                }

                if (x.Age > y.Age)
                {
                    result = -1;
                }

                if (result == 0)
                {
                    result = x.Nom.CompareTo(y.Nom);
                    result = result * -1;
                }

                return result;
            }
        }
    }
}