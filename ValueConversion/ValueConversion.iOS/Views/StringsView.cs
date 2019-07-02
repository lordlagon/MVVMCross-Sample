using ValueConversion.Core.ViewModels;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;
using UIKit;

namespace ValueConversion.UI.Touch
{
    public partial class StringsView : MvxViewController
    {
        public StringsView() : base("StringsView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.CreateBinding(TextEditor).To<StringsViewModel>(vm => vm.TheText).Apply();
            this.CreateBinding(LengthLabel).To<StringsViewModel>(vm => vm.TheText)
                .WithConversion("StringLength").Apply();
            this.CreateBinding(ReversedLabel).To<StringsViewModel>(vm => vm.TheText)
                .WithConversion("StringReverse").Apply();

            this.View.AddGestureRecognizer(new UITapGestureRecognizer(() => { TextEditor.ResignFirstResponder(); }));
        }
    }
}