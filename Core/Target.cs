namespace Core
{
    using Serilog;
    using Serilog.Context;

    public class Target
    {
        public void DoSomething()
        {
            var logger = new LoggerConfiguration().WriteTo.ColoredConsole().CreateLogger();

            using(LogContext.PushProperty("MyPropery", "foo"))
            {
                logger.Information("I CAN LOG");
            }
        }
    }
}
