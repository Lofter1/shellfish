using Avalonia;
using Avalonia.Logging.Serilog;
using Avalonia.ReactiveUI;
using Microsoft.EntityFrameworkCore;

namespace DesktopApp
{
    class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        public static void Main(string[] args)
        {
            using (var dbContext = new DataAccess.ShellFishDbContext())
            {
                dbContext.Database.Migrate();
            }
            
            BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args);
        }

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToDebug()
                .UseReactiveUI();
    }
}
