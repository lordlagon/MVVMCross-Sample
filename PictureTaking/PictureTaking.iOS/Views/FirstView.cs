using PictureTaking.Core.ViewModels;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;

namespace PictureTaking.Touch
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(TakeButton).To(vm => vm.TakePictureCommand);
            set.Bind(ChooseButton).To(vm => vm.ChoosePictureCommand);
            set.Bind(PictureImage).To(vm => vm.Bytes).WithConversion("InMemoryImage");
            set.Apply();
        }
    }
}