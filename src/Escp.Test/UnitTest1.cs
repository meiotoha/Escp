using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Escp.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Escp.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            using var ms = new MemoryStream();
            using var ps = EscPosCoreManager.Connect(ms);
            var pt = ps.Begin();
            pt.PrintText("aaa")
                .Bold()
                .PrintText("11bbcc")
                .UnsetBold()
                .Init();
            ms.Position = 0;
            using var rd = new StreamReader(ms,Encoding.Default);
            var str = rd.ReadToEnd();

            Debug.WriteLine(str);

            var template = "{Name}'s Home";

            var pa = Regex.Matches(template,"/{\\w+}/");

            Assert.IsNotNull(str);
        }

    }
}
