using System;

namespace ContentConsole
{
    public static class Program
    {
        public static void Main(string[] args)
        {
           
            var userClass = new UserClass();
            var adminClass = new AdminClass();
            var readerClass = new ReaderClass();
            var curatorClass = new CuratorClass();

            userClass.DoTheProcess();
            adminClass.DoTheProcess();
            readerClass.DoTheProcess();
            curatorClass.DoTheProcess();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}