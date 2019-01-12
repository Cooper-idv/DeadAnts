using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeadAnts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadAnts.Tests
{
    [TestClass()]
    public class Kata002Tests
    {
        [TestMethod()]
        public void getDeadAntsCountTest()
        {
            Assert.AreEqual(3, Kata002.getDeadAntsCount("...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t"));
            Assert.AreEqual(0, Kata002.getDeadAntsCount("ant ant ant ant"));
            Assert.AreEqual(0, Kata002.getDeadAntsCount(null));
            Assert.AreEqual(2, Kata002.getDeadAntsCount("ant anantt aantnt"));
            Assert.AreEqual(1, Kata002.getDeadAntsCount("ant ant .... a nt"));
            Assert.AreEqual(11, Kata002.getDeadAntsCount("ntttn.ntat..t.ta..a.n.a.a.t..an.tn.a.nt.an..nt.a.anan"));
            Assert.AreEqual(9, Kata002.getDeadAntsCount("nt....aant.tn.aattt..n.t.a.a...anttn.nat.aa...a.nnntn"));
            Assert.AreEqual(10, Kata002.getDeadAntsCount("..aat..ant.a.nnnat.ta.at.a.nntt..nt.att.n....ntna.a.n"));
            Assert.AreEqual(11, Kata002.getDeadAntsCount("..n.ntt.a..an.ntna..atata.nnaa.nttt....na.a.t.nt.nt.a"));
            Assert.AreEqual(10, Kata002.getDeadAntsCount(".....aa.....nnt..ntnatant..aatnt.a.taan.ta.nnattn.nt."));
            Assert.AreEqual(9, Kata002.getDeadAntsCount("....nnt.ntantaatt.nn..a.a.ntaantnt...a..nt.a.n.ta.at."));
            Assert.AreEqual(10, Kata002.getDeadAntsCount("....taa.ntan.ta.n.ntantt.nn..n.a..n.a.tnta.aatt...nta"));
            Assert.AreEqual(11, Kata002.getDeadAntsCount("...ana.nnn..a.n.tnt.nta.ttntn..a.t.a.nt.at.na.a.att.a"));
            Assert.AreEqual(11, Kata002.getDeadAntsCount("a.n.a.ntntn..a.at..t..na..tttat.ta.nn.na.tn..nna.at.a"));
            Assert.AreEqual(11, Kata002.getDeadAntsCount(".nt.a.tt...n.a.an.ana.t..n.atna.ntt...a..ntttaann.nta"));
            Assert.AreEqual(10, Kata002.getDeadAntsCount(".atn.a...nta.na.n.t.aaa.t..at..aant...n.nnna.ntt.ttnt"));
            Assert.AreEqual(11, Kata002.getDeadAntsCount("n.taa...na.tn..a.nt.a..attnttat.n.na..at..aan..nnnt.t"));
            Assert.AreEqual(11, Kata002.getDeadAntsCount("t..n..a.nn...n.nnata.ta...aan.a.na.t.n.attttnata.nt.t"));
            Assert.AreEqual(11, Kata002.getDeadAntsCount("tn.a.n.nn..attna.t...a.a..aan.a.ttt..n.natt.an.ntta.n"));
            Assert.AreEqual(11, Kata002.getDeadAntsCount("at.aa.n.natn.an.nna...a..n.tttaa.ntn...tnt.a.a.tt.nt."));
            Assert.AreEqual(11, Kata002.getDeadAntsCount(".annn.n..ttnt..tn.tntatna..tat..ta..aa.n.an.a.n.aat.."));
            Assert.AreEqual(11, Kata002.getDeadAntsCount(".a.n.nt.t.tna.nntn.tntnt..t.aa..at.n.t.taa.aa.a.n.n.a"));
            Assert.AreEqual(11, Kata002.getDeadAntsCount("ntnntnt.aaa.n.t...a.n.a.n.aaa.an.t.tn.ttnt...t.t.an.a"));
            Assert.AreEqual(11, Kata002.getDeadAntsCount("naa...nna..nt..nnt...aaan.ntt.t.ta.atntnt.a.aa..t.t.n"));
            Assert.AreEqual(11, Kata002.getDeadAntsCount("n.atnt..aattaat..ta.n..nn..nt.a..a.n.n..a.nt.tntaa.tn"));
        }
    }
}