using AppKit;

namespace FormTest.MacOS
{
    static class MainClass
    {
        static void Main(string[] args)
        {
            NSApplication.Init();
            NSApplication.SharedApplication.Delegate = (AppKit.INSApplicationDelegate)new AppDelegate();
            NSApplication.SharedApplication.MainMenu = new NSMenu();
            NSApplication.Main(args);
        }
    }
}
