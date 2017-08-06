using System;
using Foundation;
using AppKit;

namespace 飯島の電車賃を測るアプリ
{
    public partial class MainWindowController : NSWindowController
    {
        public MainWindowController(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public MainWindowController(NSCoder coder) : base(coder)
        {
        }

        public MainWindowController() : base("MainWindow")
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }

        public new MainWindow Window
        {
            get { return (MainWindow)base.Window; }
        }
      //  partial void ClickedButton(Foundation.NSObject sender)
      //  {

            // Update counter and label
            //= MainClass.w.getResult();
        }
    }
//}
