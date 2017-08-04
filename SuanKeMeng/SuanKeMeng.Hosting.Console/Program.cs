using System;

namespace SuanKeMeng.Hosting.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //开启服务
            new Core.ApplicationBuilder()
                .UseDataServer(() => new Core.Server.ServerOptions() { BossGroup = 2, WorkerGroup = 8, Port = 8092 })
                .Build()
                .Run();
            System.Console.Read();

        }
    }
}
