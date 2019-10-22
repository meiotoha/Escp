using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Text.RegularExpressions;
using Escp.Core;
using Escp.Core.Core;
using Escp.Extend.Core;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            //var mgr =   EscPosCoreManager.Connect("127.0.0.1",9100);
            //var core = mgr.Begin();

            //core.Init()
            //    .Align(Alignment.Center)
            //    .Bold()
            //    .PrintText("AAAAA")
            //    .CancelBold()
            //    .LineFeed(1)
            //    .Align(Alignment.Left)
            //    .PrintText("测试中文wwwwwwwww")
            //    .LineFeed(1);

            //var para = new
            //{
            //    Core=".net Core",
            //    Extensions = "Version 2.1"
            //};
            dynamic  para = new ExpandoObject();
            para.Core = ".net Core";
            para.Extensions = "version 2.0";


            var tempText = "Text {Core}  is {Extensions} \n {{ vvvv }} tttt";

            tempText = tempText.ParseText((ExpandoObject)para);

            Console.WriteLine(tempText);
        }

    }
}
