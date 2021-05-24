using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Cheques.Test
{
    [TestClass]
    public class Conversor
    {
        
        [TestMethod]
        public void DeveRetornarCentavos()
        {
            double Centavos = 0.5;
            string numeroString = Convert.ToString(Centavos);
            Assert.AreEqual(0.5, Centavos);
        }

        [TestMethod]
        public void DeveRetornarUmReal()
        {
            double UmReal = 1;
            string numeroString = Convert.ToString(UmReal);

            Assert.AreEqual(1, UmReal);
        }

        [TestMethod]
        public void DeveRetornarDoisReais()
        {
            double DoisReais = 2;
            string numeroString = Convert.ToString(DoisReais);

            Assert.AreEqual(2, DoisReais);
        }

        [TestMethod]
        public void DeveRetornarDezReais()
        {
            double DezReal = 10;
            string numeroString = Convert.ToString(DezReal);

            Assert.AreEqual(10, DezReal);
        }

        [TestMethod]
        public void DeveRetornarCemReais()
        {
            double CemReais = 100;
            string numeroString = Convert.ToString(CemReais);

            Assert.AreEqual(100, CemReais);
        }

        [TestMethod]
        public void DeveRetornarMilReais()
        {
            double MilReais = 1000;
            string numeroString = Convert.ToString(MilReais);

            Assert.AreEqual(1000, MilReais);
        }

        [TestMethod]
        public void DeveRetornarDezMilReais()
        {
            double DezMilReais = 10000;
            string numeroString = Convert.ToString(DezMilReais);

            Assert.AreEqual(10000, DezMilReais);
        }

        [TestMethod]
        public void DeveRetornarCemMilReais()
        {
            double CemMilReais = 100000;
            string numeroString = Convert.ToString(CemMilReais);

            Assert.AreEqual(100000, CemMilReais);
        }

        [TestMethod]
        public void DeveRetornarUmMilhaoDeReais()
        {
            double UmMilhaoDeReais = 1000000;
            string numeroString = Convert.ToString(UmMilhaoDeReais);

            Assert.AreEqual(1000000, UmMilhaoDeReais);
        }

        [TestMethod]
        public void DeveRetornarDezMilhoesDeReais()
        {
            double DezMilhoesDeReais = 10000000;
            string numeroString = Convert.ToString(DezMilhoesDeReais);

            Assert.AreEqual(10000000, DezMilhoesDeReais);
        }

        [TestMethod]
        public void DeveRetornarCemMilhoesDeReais()
        {
            double CemMilhoesDeReais = 1000000000;
            string numeroString = Convert.ToString(CemMilhoesDeReais);

            Assert.AreEqual(1000000000, CemMilhoesDeReais);
        }

        [TestMethod]
        public void DeveRetornarUmBilhaoDeReais()
        {
            double UmBilhaoDeReais = 10000000000;
            string numeroString = Convert.ToString(UmBilhaoDeReais);

            Assert.AreEqual(10000000000, UmBilhaoDeReais);
        }

        [TestMethod]
        public void DeveRetornarDezBilhoesDeReais()
        {
            double DezBilhaoDeReais = 100000000000;
            string numeroString = Convert.ToString(DezBilhaoDeReais);

            Assert.AreEqual(100000000000, DezBilhaoDeReais);
        }
    }
}
