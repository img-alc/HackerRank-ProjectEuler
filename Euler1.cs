using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;


class Exercise1
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());


        for (int a0 = 0; a0 < t; a0++)
        {

            var n = BigInteger.Parse(Console.ReadLine());

       
            var m3 = BigInteger.Divide((n - 1), 3);
            var m5 = BigInteger.Divide((n - 1),5);
            var m15 = BigInteger.Divide((n - 1),15);
                
            var sum3 = 3 * BigInteger.Divide(BigInteger.Multiply(m3, BigInteger.Add(m3, 1)), 2);
            var sum5 = 5 * BigInteger.Divide(BigInteger.Multiply(m5, BigInteger.Add(m5, 1)), 2);
            var sum15 = 15 * BigInteger.Divide(BigInteger.Multiply(m15, BigInteger.Add(m15, 1)), 2);

            Console.WriteLine(sum3 + sum5 - sum15);
    

        }
    }
}