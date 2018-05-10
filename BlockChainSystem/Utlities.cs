using System;
using System.Collections.Generic;
using System.Text;
using Blake2Sharp;

namespace BlockChainSystem
{
    public static class Utlities
    {
        public static string GetHashStringBlacke2b(this string clearstring)
        {
            return Convert.ToBase64String(Blake2B.ComputeHash(Blake2B.ComputeHash(Encoding.UTF8.GetBytes(clearstring))));
        }
    }
}
