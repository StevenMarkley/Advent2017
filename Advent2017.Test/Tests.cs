using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Advent2017.Test
{
    [TestClass]
    public class Tests
    {
        #region Day 1
        [TestMethod]
        public void Test_1_1_1()
        {
            var data = "123451";

            var service = new Advent_1_1();

            var result = service.InverseCaptcha(data);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test_1_1_2()
        {
            var data = "1223451";

            var service = new Advent_1_1();

            var result = service.InverseCaptcha(data);

            Assert.AreEqual(3, result);
        }


        [TestMethod]
        public void Test_1_2_1()
        {
            var data = "11";

            var service = new Advent_1_1();

            var result = service.InverseCaptchaHalfway(data);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Test_1_2_2()
        {
            var data = "2131";

            var service = new Advent_1_1();

            var result = service.InverseCaptchaHalfway(data);

            Assert.AreEqual(2, result);
        }

        #endregion

        #region Day 2

        [TestMethod]
        public void Test_2_1_1()
        {
            var data = "1\t2\r\n2\t1";
            var service = new Advent_2_1();

            var result = service.Checksum(data);

            Assert.AreEqual(2, result);
        }


        [TestMethod]
        public void Test_2_2_1()
        {
            var data = "2\t4\t3\r\n3\t4\t2";
            var service = new Advent_2_1();

            var result = service.ChecksumDivisible(data);

            Assert.AreEqual(4, result);
        }
        #endregion

    }
}
