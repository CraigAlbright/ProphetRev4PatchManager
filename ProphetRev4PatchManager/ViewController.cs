using System;

using AppKit;
using Foundation;

namespace ProphetRev4PatchManager
{
    /// <summary>
    /// NSViewController for default view
    /// </summary>
    public partial class ViewController : NSViewController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        public ViewController(IntPtr handle) : base(handle)
        {
        }
        /// <summary>
        /// Override to View did load for additional setup
        /// </summary>
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }
        /// <summary>
        /// The view?
        /// </summary>
        public override NSObject RepresentedObject
        {
            get => base.RepresentedObject;
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
