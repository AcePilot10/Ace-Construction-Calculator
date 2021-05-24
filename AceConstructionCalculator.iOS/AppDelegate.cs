﻿using Foundation;
using Syncfusion.ListView.XForms.iOS;
using Syncfusion.XForms.iOS.DataForm;
using UIKit;

namespace AceConstructionCalculator.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            Syncfusion.XForms.iOS.PopupLayout.SfPopupLayoutRenderer.Init();
            Syncfusion.XForms.iOS.Border.SfBorderRenderer.Init();
            Syncfusion.XForms.iOS.Buttons.SfButtonRenderer.Init();
            SfListViewRenderer.Init();
            SfDataFormRenderer.Init();
            Syncfusion.XForms.iOS.MaskedEdit.SfMaskedEditRenderer.Init();
            Syncfusion.XForms.iOS.TextInputLayout.SfTextInputLayoutRenderer.Init();
            Syncfusion.XForms.iOS.Accordion.SfAccordionRenderer.Init();
            Syncfusion.SfDataGrid.XForms.iOS.SfDataGridRenderer.Init();
            Syncfusion.XForms.iOS.Expander.SfExpanderRenderer.Init();
            Syncfusion.XForms.iOS.ProgressBar.SfLinearProgressBarRenderer.Init();

            LoadApplication(new App());
            return base.FinishedLaunching(app, options);
        }
    }
}
