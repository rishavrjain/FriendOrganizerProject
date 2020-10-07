﻿using FriendOrganizerUI.Events;
using Prism.Commands;
using Prism.Events;
using System;
using System.Windows.Input;

namespace FriendOrganizerUI.ViewModel
{
    public class NavigationItemViewModel: ViewModelBase
    {
        private string _displayMember;

        public NavigationItemViewModel(int id, string displayMember,
            string detailViewModelName,
            IEventAggregator eventAggregator)
        {
            Id = id;
            DisplayMember = displayMember;
            _eventAggregator = eventAggregator;
            _detailViewModelName = detailViewModelName;
            OpenDetailViewCommand = new DelegateCommand(OnOpenDetailViewExecute);
        }

        public int Id { get; }
        public string DisplayMember 
        {
            get { return _displayMember; }
            set
            {
                _displayMember = value;
                OnPropertyChanged();
            }
        }

        private IEventAggregator _eventAggregator;
        private string _detailViewModelName;

        public ICommand OpenDetailViewCommand { get; }

        private void OnOpenDetailViewExecute()
        {
            _eventAggregator.GetEvent<OpenDetailViewEvent>()
                .Publish(
                new OpenDetailViewEventArgs
                {
                    Id = Id,
                    ViewModelName = _detailViewModelName
                });
        }

    }
}
