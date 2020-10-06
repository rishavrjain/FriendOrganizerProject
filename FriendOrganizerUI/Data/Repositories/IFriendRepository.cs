﻿using FriendOrganizer.Model;
using System.Threading.Tasks;

namespace FriendOrganizerUI.Data.Repositories
{
    public interface IFriendRepository
    {
        Task<Friend> GetByIdAsync(int friendId);
        Task SaveAsync();
        bool HasChanges();
        void Add(Friend friend);
        void Remove(Friend model);
        void RemovePhoneNumber(FriendPhoneNumber model);
    }
}