﻿using System.Threading.Tasks;

namespace FriendOrganizerUI.ViewModel
{
    public interface IDetailViewModel
    {
        Task LoadAsync(int id);
        bool HasChanges { get; }
        int Id { get; }
    }
}