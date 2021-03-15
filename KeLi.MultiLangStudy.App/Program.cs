using System;
using System.Globalization;
using System.Threading;
using KeLi.MultiLangStudy.App.Properties;

namespace KeLi.MultiLangStudy.App
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Default Lang: ");
            Console.WriteLine(Resources.LANG_TEST);
            Console.WriteLine();

            Console.Write("zh-CN Lang: ");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");
            Console.WriteLine(Resources.LANG_TEST);
            Console.WriteLine();

            Console.Write("zh-TW Lang: ");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-TW");
            Console.WriteLine(Resources.LANG_TEST);
            Console.WriteLine();

            Console.Write("en-US Lang: ");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Console.WriteLine(Resources.LANG_TEST);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}