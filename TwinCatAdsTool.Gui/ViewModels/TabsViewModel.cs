﻿using System;
using System.Linq;
using TwinCatAdsTool.Interfaces.Commons;
using TwinCatAdsTool.Interfaces.Extensions;

namespace TwinCatAdsTool.Gui.ViewModels
{
    public class TabsViewModel : ViewModelBase
    {
        private readonly IViewModelFactory viewModelFactory;

        public TabsViewModel(IViewModelFactory viewModelFactory)
        {
            this.viewModelFactory = viewModelFactory;
        }

        public BackupViewModel BackupViewModel { get; set; }
        public CompareViewModel CompareViewModel { get; set; }

        public ExploreViewModel ExploreViewModel { get; set; }

        public RestoreViewModel RestoreViewModel { get; set; }

        public override void Init()
        {
            BackupViewModel = viewModelFactory.CreateViewModel<BackupViewModel>();
            BackupViewModel.AddDisposableTo(Disposables);

            CompareViewModel = viewModelFactory.CreateViewModel<CompareViewModel>();
            CompareViewModel.AddDisposableTo(Disposables);


            ExploreViewModel = viewModelFactory.CreateViewModel<ExploreViewModel>();
            ExploreViewModel.AddDisposableTo(Disposables);


            RestoreViewModel = viewModelFactory.CreateViewModel<RestoreViewModel>();
            RestoreViewModel.AddDisposableTo(Disposables);
        }
    }
}