﻿using MvvmCross.Core.ViewModels;

namespace MvxPageDemo.ViewModels
{
    public class SecondPageViewModel : MvxViewModel, IMvxPagedViewModel
    {
        public string PagedViewId { get { return ("SecondPage"); } }
        private string _pageTitle = null;

        public string PageTitle
        {
            get { return (_pageTitle); }
            set { _pageTitle = value; RaisePropertyChanged(() => PageTitle); }
        }

        public SecondPageViewModel()
        {
            _pageTitle = "Second Page";
        }
    }
}