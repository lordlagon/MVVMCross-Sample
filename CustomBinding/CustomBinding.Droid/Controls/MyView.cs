using System;
using Android.Content;
using Android.Text;
using Android.Util;
using Android.Widget;

namespace CustomBinding.Droid.Controls
{
    public class MyView : EditText
    {
        public MyView(Context context, IAttributeSet attrs) :
            base(context, attrs)
        {
            Initialize();
        }

        public MyView(Context context, IAttributeSet attrs, int defStyle) :
            base(context, attrs, defStyle)
        {
            Initialize();
        }

        private void Initialize()
        {
            this.AfterTextChanged += OnAfterTextChanged; 
        }

        private void OnAfterTextChanged(object sender, AfterTextChangedEventArgs afterTextChangedEventArgs)
        {
            var handler = UnusualNameChanged;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        public string SpecialProperty
        {
            get { return Text; }
            set { Text = value; }
        }

        public event EventHandler UnusualNameChanged;
    }
}