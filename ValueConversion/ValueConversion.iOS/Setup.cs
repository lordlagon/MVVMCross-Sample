using System.Collections.Generic;
using System.Reflection;
using ValueConversion.Core;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Plugins;
using MvvmCross.Plugins.Color;
using MvvmCross.Plugins.Visibility;
using System.Collections;

namespace ValueConversion.UI.Touch
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

		protected override IEnumerable<Assembly> ValueConverterAssemblies
        {
            get
            {
				var toReturn = base.ValueConverterAssemblies as IList;
                toReturn.Add(typeof(MvxNativeColorValueConverter).Assembly);
                toReturn.Add(typeof(MvxVisibilityValueConverter).Assembly);
                return (List<Assembly>)toReturn;
            }
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }

    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to
    // application events from iOS.
}