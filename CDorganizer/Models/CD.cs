using System;
using System.Collections.Generic;

namespace CDorganizer.Models
{
  public class CD
  {
    private string _albumName;
    private string _genre;
    private string _releaseYear;
    private int _id;
    private static List<CD> _instances = new List<CD> {};

    public CD (string albumName, string genre, string releaseYear)
    {
      _albumName = albumName;
      _genre = genre;
      _releaseYear = releaseYear;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetAlbumName()
    {
      return _albumName;
    }
    public void SetAlbumName(string newAlbumName)
    {
      _albumName = newAlbumName;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<CD> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static CD Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}
