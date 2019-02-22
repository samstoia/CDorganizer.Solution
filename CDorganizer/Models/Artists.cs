using System;
using System.Collections.Generic;

namespace CDorganizer.Models
{
  public class Artists
  {
    private static List<Artists> _instances = new List<Artists>{};
    private string _artistName;
    private int _id;
    private List<CD> _artists;

    public Artists(string artistName)
    {
      _artistName = artistName;
      _instances.Add(this);
      _id = _instances.Count;
      _artists = new List<CD>{};
    }

    public string GetName()
    {
      return _artistName;
    }

    public int GetId()
    {
      return _id;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Artists> GetAll()
    {
      return _instances;
    }

    public static Artists Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public List<CD>GetCDs()
    {
      return _artists;
    }

    public void AddCD(CD cd)
    {
      _artists.Add(cd);
    }
  }
}
