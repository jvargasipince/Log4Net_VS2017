using System;

namespace Demo_Log4Net
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Main(string[] args)
        {

            log.Info("Bienvenidos a nuestra demo de Log4Net");
            Console.WriteLine("Presione enter");
            Console.ReadLine();
        }
    }
}
