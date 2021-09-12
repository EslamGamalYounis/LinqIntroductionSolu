using System;
using System.Collections;
using System.Collections.Generic;


namespace Features
{
    public static class MyLinq
    { 
        public static int Count(this IEnumerable sequence)
        {
            int count = 0;
            foreach(var item in sequence)
            {
                count += 1;
            }
            return count;
        }
    }
}
