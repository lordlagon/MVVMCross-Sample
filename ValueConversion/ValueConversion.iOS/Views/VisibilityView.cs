using ValueConversion.Core.ViewModels;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;

namespace ValueConversion.UI.Touch
{
    public partial class VisibilityView : MvxViewController
    {
        public VisibilityView() : base("VisibilityView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.CreateBinding(TheThing).For("Visibility")
                .To<VisibilityViewModel>(vm => vm.MakeItVisible)
                .WithConversion("Visibility").Apply();
            this.CreateBinding(ShowSwitch).To<VisibilityViewModel>(vm => vm.MakeItVisible)
                .Apply();
        }
    }
}