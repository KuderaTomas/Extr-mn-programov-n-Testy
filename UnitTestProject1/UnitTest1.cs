using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSpecializacePOS()
        {
            Hrac hr = new Hrac("Petr","Berserk",1,2,3);
            Assert.IsTrue(hr.Specializace.Contains("Kouzelník") || hr.Specializace.Contains("Berserk") || hr.Specializace.Contains("Inženýr") || hr.Specializace.Contains("Cizák"));
        }
        [TestMethod]
        public void TestSpecializaceNEG()
        {
            Hrac hr = new Hrac("Petr", "opravář", 1, 2, 3);
            Assert.IsTrue(hr.Specializace.Contains("Kouzelník") || hr.Specializace.Contains("Berserk") || hr.Specializace.Contains("Inženýr") || hr.Specializace.Contains("Cizák"));
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void TestPracePOS()
        {
            string pr = "Obchodnik";
            string pr1 = NPC.Prace.Nepritel.ToString();
            string pr2 = NPC.Prace.Obchodnik.ToString();
            string pr3 = NPC.Prace.Obyvatel.ToString();
            Assert.IsTrue(pr==pr1||pr==pr2||pr==pr3);
        }
        [TestMethod]
        public void TestPraceNEG()
        {
            string pr = "Zebrak";
            string pr1 = NPC.Prace.Nepritel.ToString();
            string pr2 = NPC.Prace.Obchodnik.ToString();
            string pr3 = NPC.Prace.Obyvatel.ToString();
            Assert.IsTrue(pr == pr1 || pr == pr2 || pr == pr3);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void TestSilaPOS()
        {
            NPC npc = new NPC("Obchodník",NPC.Prace.Obchodnik, "BOSS");
            Assert.IsTrue(npc.Sila.Contains("BOSS"));
        }
        [TestMethod]
        public void TestSilaNEG()
        {
            NPC npc = new NPC("Obchodník", NPC.Prace.Obchodnik, "weirdo");
            Assert.IsTrue(npc.Sila.Contains("BOSS"));
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void TestDelkyJmenaPOS()
        {
            HerniPostava pos = new HerniPostava("Adam");
            int a = 0;
            foreach (char c in pos.Jmeno)
            {
                a++;
            }
            Assert.IsTrue(a <= 10 && a > 0);
        }
        [TestMethod]
        public void TestDelkyJmenaNEG1()
        {
            HerniPostava pos = new HerniPostava("Adamixiovičský");
            int a = 0;
            foreach (char c in pos.Jmeno)
            {
                a++;
            }
            Assert.IsTrue(a <= 10 && a > 0);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void TestDelkyJmenaNEG2()
        {
            HerniPostava pos = new HerniPostava("");
            int a = 0;
            foreach (char c in pos.Jmeno)
            {
                a++;
            }
            Assert.IsTrue(a <= 10 && a > 0);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void TestPoziceXPOS1()
        {
            HerniPostava hp = new HerniPostava("Pavel");
            hp.poziceX = 10;
            Assert.AreEqual(hp.poziceX, 10);
        }
        [TestMethod]
        public void TestPoziceXNEG1()
        {
            HerniPostava hp = new HerniPostava("Pavel");
            hp.poziceX = 10;
            Assert.AreEqual(hp.poziceX, 15);
        }
        [TestMethod]
        public void TestPoziceXPOS2()
        {
            HerniPostava hp = new HerniPostava("Pavel");
            hp.poziceX = -10;
            Assert.AreEqual(hp.poziceX, -10);
        }
        [TestMethod]
        public void TestPoziceXNEG2()
        {
            HerniPostava hp = new HerniPostava("Pavel");
            hp.poziceX = -10;
            Assert.AreEqual(hp.poziceX, -15);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void TestPoziceYPOS1()
        {
            HerniPostava hp = new HerniPostava("Pavel");
            hp.poziceY = 10;
            Assert.AreEqual(hp.poziceY, 10);
        }
        [TestMethod]
        public void TestPoziceYNEG1()
        {
            HerniPostava hp = new HerniPostava("Pavel");
            hp.poziceY = 10;
            Assert.AreEqual(hp.poziceY, 15);
        }
        [TestMethod]
        public void TestPoziceYPOS2()
        {
            HerniPostava hp = new HerniPostava("Pavel");
            hp.poziceY = -10;
            Assert.AreEqual(hp.poziceY, -10);
        }
        [TestMethod]
        public void TestPoziceYNEG2()
        {
            HerniPostava hp = new HerniPostava("Pavel");
            hp.poziceY = -10;
            Assert.AreEqual(hp.poziceY, -15);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void TestBarvaVlasuPOS()
        {
            int vlasy = Convert.ToInt32(Hrac.BarvaVlasu.Blond);
            Assert.AreEqual(vlasy,1);
        }
        [TestMethod]
        public void TestBarvaVlasuNEG()
        {
            int vlasy = Convert.ToInt32(Hrac.BarvaVlasu.Kastanova);
            Assert.AreEqual(vlasy, 2);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [TestMethod]
        public void TestOblicejPOS()
        {
            int vlasy = Convert.ToInt32(Hrac.Oblicej.Uchoplesk);
            Assert.AreEqual(vlasy, 1);
        }
        [TestMethod]
        public void TestOblicejNEG()
        {
            int vlasy = Convert.ToInt32(Hrac.Oblicej.MakeUp);
            Assert.AreEqual(vlasy, 3);
        }
    }
}
    
