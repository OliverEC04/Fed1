using ObjCRuntime;
using UIKit;

namespace Ledger
{
    public class Program
    {
        // This is the FrontPage entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, typeof(AppDelegate));
        }
    }
}
