using Android.Content;
using Android.Views;
using CrossUI.Droid.Dialog.Elements;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Binding.Droid.Views;

namespace DialogExamples.Droid.BindableElements
{
    public class CustomViewElement
        : ViewElement
          , IBindableElement
    {
        public CustomViewElement(Context context)
        {
            BindingContext = new MvxAndroidBindingContext(context, (IMvxLayoutInflaterHolder)context);
        }

        public IMvxBindingContext BindingContext { get; set; }

        private View _cachedView;

        protected override View GetViewImpl(Context context, ViewGroup parent)
        {
            // note that this setup uses one view per element - so it's not memory efficient
            // if you have large lists and if you  really need to use dialog, then you'll need to use
            // convertView - which requires putting the binding context inside the _cachedView - e.g. using MvxFrameControl
            if (_cachedView != null)
                return _cachedView;

            _cachedView = this.BindingInflate(Resource.Layout.CustomPersonView, null);
            return _cachedView;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                BindingContext.ClearAllBindings();
            }
            base.Dispose(disposing);
        }

        public virtual object DataContext
        {
            get { return BindingContext.DataContext; }
            set { BindingContext.DataContext = value; }
        }
    }
}