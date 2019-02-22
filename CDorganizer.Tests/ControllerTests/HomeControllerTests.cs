using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CDorganizer.Controllers;
using CDorganizer.Models;

namespace CDorganizer.TestTools
{
    [TestClass]
    public class HomeControllerTest
    {
      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
        HomeController controller = new HomeController();

        ActionResult indexView = controller.Index();

        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }

      [TestMethod]
      public void Index_HasCorrectModelType_ItemList()
      {
        HomeController controller = new HomeController();
        ViewResult indexView = new HomeController().Index() as ViewResult;

        var result = indexView.ViewData.Model;

        Assert.IsInstanceOfType(result, typeof(List<CD>));
      }

      

    }
}
