using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CDorganizer.Models;

namespace CDorganizer.Tests
{
  [TestClass]
  public class ArtistsTest : IDisposable
  {
    public void Dispose()
    {
      Artists.ClearAll();
    }

    [TestMethod]
    public void ArtistsConstructor_CreateAnInstanceOfArtists_Artists()
    {
      Artists newArtist = new Artists("Test Artist");
      Assert.AreEqual(typeof(Artists), newArtist.GetType());
    }

    [TestMethod]
    public void GetName_GetArtistName_String()
    {
      string testName = "A.B.B.A.";
      string result = new Artists(testName).GetName();
      Assert.AreEqual(testName, result);
    }

    [TestMethod]
    public void GetId_GetArtistId_Int()
    {
      string testName = "My Chemical Romance";
      int result = new Artists(testName).GetId();
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllArtistObjects_ArtistList()
    {
      string testArtist01 = "Prince";
      string testArtist02 = "Janelle Monae";
      Artists newArtist01 = new Artists(testArtist01);
      Artists newArtist02 = new Artists(testArtist02);
      List<Artists> newArtistList = new List<Artists> { newArtist01, newArtist02 };
      List<Artists> result = Artists.GetAll();
      CollectionAssert.AreEqual(newArtistList,result);
    }

    [TestMethod]
    public void Find_RetrnCorrectArtists_Artists()
    {
      string testArtist01 = "Prince";
      string testArtist02 = "Janelle Monae";
      Artists newArtist01 = new Artists(testArtist01);
      Artists newArtist02 = new Artists(testArtist02);
      Artists result = Artists.Find(2);
      Assert.AreEqual(newArtist02,result);
    }

    [TestMethod]
    public void GetCDs_ReturnEmptyCDList_CDList()
    {
      string name = "Janelle Monae";
      Artists newArtist = new Artists(name);
      List<CD> newCD = new List<CD>{};
      List<CD> result = newArtist.GetCDs();
      CollectionAssert.AreEqual(newCD, result);
    }

    [TestMethod]
    public void AddCD_AssociatesCDWithArtist_CDList()
    {
      string album = "Electric Lady";
      CD newCD = new CD(album, "test", "test");
      List<CD> newCDList = new List<CD> { newCD };
      string artist = "Janelle Monae";
      Artists newArtist = new Artists(artist);
      newArtist.AddCD(newCD);

      List<CD> result = newArtist.GetCDs();

      CollectionAssert.AreEqual(newCDList, result);
    }
  }
}
