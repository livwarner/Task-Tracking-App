using HtmlAgilityPack;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Xunit;

namespace Tasker.Tests.CreatingTheLayoutAndNavigation
{
    public class CreateTaskFriendlyRouteTests
    {
        [Fact(DisplayName = "Adding a Friendly Route @create-friendly-route")]
        public void CreateTaskFriendlyRouteTest()
        {
            var filePath = TestHelpers.GetRootString() + "Tasker" 
                + Path.DirectorySeparatorChar + "Pages"
                + Path.DirectorySeparatorChar + "CreateTask.cshtml";

            Assert.True(File.Exists(filePath), "`CreateTask.cshtml` should exist in the Pages folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            Assert.True(doc.DocumentNode.InnerText.Contains("@page \"/create-task\""),
                "`CreatePage.cshtml` should contain the text `@page \"/create-task\"` at the top of the file to enable a user friendly route.");
        }
    }
}
