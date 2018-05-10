using System;
using Xunit;
using System.Diagnostics;
using static BlockChainSystem.Utlities;
namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string s = Guid.NewGuid().ToString();
            uint nonce = 0;
            string p = "000";
            Stopwatch sp = new Stopwatch();
            sp.Start();
            while (true)
            {
                if ((s + (nonce++).ToString()).GetHashStringBlacke2b().Substring(0, 3) == p)
                    break;
            }
            sp.Stop();
            Assert.True(sp.Elapsed < TimeSpan.FromSeconds(2));
        }
    }
}
