using AppKit;
using Foundation;

namespace ProphetRev4PatchManager
{
    /// <summary>
    /// MacOS App Delegate
    /// </summary>
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        /// <summary>
        /// 
        /// </summary>
        public AppDelegate()
        {
        }
        /// <summary>
        /// MacOS Cocoa API call for finish launch
        /// </summary>
        /// <param name="notification"></param>
        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
        }
        /// <summary>
        /// MacOS API call before exit
        /// </summary>
        /// <param name="notification"></param>
        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
