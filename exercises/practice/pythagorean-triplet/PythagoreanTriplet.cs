using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {

        // a < b < c => a < sum/3
        for (int a=1; a<sum/3; a++)
        {
            for (int b=a+1, c=sum-a-b; b<=(sum-a)/2; b++, c--)
            {
                if (IsTriplet((a,b,c)))
                {
                    yield return (a,b,c);
                }
            }
        }
    }

    private static bool IsTriplet((int a, int b, int c) tri) =>
        tri.a * tri.a + tri.b * tri.b == tri.c * tri.c;
}