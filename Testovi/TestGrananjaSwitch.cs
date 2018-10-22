using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp.KontrolaToka;

namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestGrananjaSwitch
    {
        [TestMethod]
        public void GrananjeSwitch_ImeDanaUTjednuVraćaPonedjeljak()
        {
            Assert.AreEqual("ponedjeljak", IspisDana.ImeDana(DayOfWeek.Monday));
        }

        [TestMethod]
        public void GrananjeSwitch_ImeDanaUTjednuVraćaUtorak()
        {
            Assert.AreEqual("utorak", IspisDana.ImeDana(DayOfWeek.Tuesday));
        }

        [TestMethod]
        public void GrananjeSwitch_ImeDanaUTjednuVraćaSrijeda()
        {
            Assert.AreEqual("srijeda", IspisDana.ImeDana(DayOfWeek.Wednesday));
        }

        [TestMethod]
        public void GrananjeSwitch_ImeDanaUTjednuVraćaČetvrtak()
        {
            Assert.AreEqual("četvrtak", IspisDana.ImeDana(DayOfWeek.Thursday));
        }

        [TestMethod]
        public void GrananjeSwitch_ImeDanaUTjednuVraćaPetak()
        {
            Assert.AreEqual("petak", IspisDana.ImeDana(DayOfWeek.Friday));
        }

        [TestMethod]
        public void GrananjeSwitch_ImeDanaUTjednuVraćaSubota()
        {
            Assert.AreEqual("subota", IspisDana.ImeDana(DayOfWeek.Saturday));
        }

        [TestMethod]
        public void GrananjeSwitch_ImeDanaUTjednuVraćaNedjelja()
        {
            Assert.AreEqual("nedjelja", IspisDana.ImeDana(DayOfWeek.Sunday));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GrananjeSwitch_ImeDanaUTjednuBacaIznimkuZaNepoznatiDan()
        {
            IspisDana.ImeDana((DayOfWeek)10);
        }

        [TestMethod]
        public void GrananjeSwitch_RadniNeradniVraćaRadniDanZaPonedjeljak()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Monday));
        }

        [TestMethod]
        public void GrananjeSwitch_RadniNeradniVraćaRadniDanZaUtorak()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Tuesday));
        }

        [TestMethod]
        public void GrananjeSwitch_RadniNeradniVraćaRadniDanZaSrijedu()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Wednesday));
        }

        [TestMethod]
        public void GrananjeSwitch_RadniNeradniVraćaRadniDanZaČetvrtak()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Thursday));
        }

        [TestMethod]
        public void GrananjeSwitch_RadniNeradniVraćaRadniDanZaPetak()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Friday));
        }

        [TestMethod]
        public void GrananjeSwitch_RadniNeradniVraćaVikendZaSubotu()
        {
            Assert.AreEqual("vikend", IspisDana.RadniNeradni(DayOfWeek.Saturday));
        }

        [TestMethod]
        public void GrananjeSwitch_RadniNeradniVraćaVikendZaNedjelju()
        {
            Assert.AreEqual("vikend", IspisDana.RadniNeradni(DayOfWeek.Sunday));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GrananjeSwitch_RadniNeradniBacaIznimkuZaNepoznatiDan()
        {
            IspisDana.ImeDana((DayOfWeek)10);
        }
    }
}
