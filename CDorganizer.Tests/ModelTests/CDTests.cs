using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CDorganizer.Models;

namespace CDorganizer.Tests
{
  [TestClass]
  public class CDTest : IDisposable
  {
    public void Dispose()
    {
      CD.ClearAll();
    }

    [TestMethod]
    public void CDConstructor_CreateAnInstanceOfCD_CD()
    {
      CD newCD = new CD("Test Album", "Test Genre", "1999");
      Assert.AreEqual(typeof(CD), newCD.GetType());
    }

    [TestMethod]
    public void GetAlbumName_GetsAlbumName_String()
    {
      string album = "Test Album";
      string result = new CD(album, "test", "test").GetAlbumName();
      Assert.AreEqual(album, result);
    }

    [TestMethod]
    public void SetAlbumName_SetAlbumName_String()
    {
      string album = "Test Album";
      CD newCD = new CD(album, "test", "test");

      string albumReplaceName = "ThisTest Album";
      newCD.SetAlbumName(albumReplaceName);
      string result = newCD.GetAlbumName();

      Assert.AreEqual(albumReplaceName, result);
    }
    [TestMethod]
    public void GetAll_ReturnsCDS_CDList()
    {
      string album01 = "Abbey Road";
      string album02 = "Help";
      CD newCD1 = new CD(album01, "test", "test");
      CD newCD2 = new CD(album02, "test", "test");
      List<CD> newList = new List<CD>{newCD1, newCD2};

      List<CD> result = CD.GetAll();
    }

    [TestMethod]
    public void GetId_CDInstantiantesWithAnIdAndGetterReturns_Int()
    {
      string albumName = "Abbey Road";
      string genre = "rock";
      string releaseYear = "1999";
      CD newCD = new CD(albumName, genre, releaseYear);

      int result = newCD.GetId();

      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectItem_Item()
    {
      string album01 = "Abbey Road";
      string album02 = "Help";
      CD newCD1 = new CD(album01, "test", "test");
      CD newCD2 = new CD(album02, "test", "test");

      CD result = CD.Find(2);

      Assert.AreEqual(newCD2, result);
    }
  }
}
