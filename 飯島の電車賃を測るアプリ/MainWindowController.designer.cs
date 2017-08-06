// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace 飯島の電車賃を測るアプリ
{
    [Register ("MainWindowController")]
    partial class MainWindowController
    {
        [Outlet]
        AppKit.NSPopUpButton Click { get; set; }

        [Outlet]
        AppKit.NSComboBox offdaycom { get; set; }

        [Outlet]
        AppKit.NSComboBox weekdaycom { get; set; }

        [Action ("ClickedButton:")]
        partial void ClickedButton (Foundation.NSObject sender);

        [Action ("offdaycom:")]
        partial void offdaycom (Foundation.NSObject sender);

        [Action ("Result:")]
        partial void Result (AppKit.NSTextField sender);

        [Action ("weekdaycom:")]
        partial void weekdaycom (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (Click != null) {
                Click.Dispose ();
                Click = null;
            }

            if (offdaycom != null) {
                offdaycom.Dispose ();
                offdaycom = null;
            }

            if (weekdaycom != null) {
                weekdaycom.Dispose ();
                weekdaycom = null;
            }
        }
    }
}
