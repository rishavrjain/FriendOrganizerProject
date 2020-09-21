using FriendOrganizer.Model;
using System.Threading.Tasks;

namespace FriendOrganizerUI.Data
{
    public interface IFriendDataService
    {
        Task<Friend> GetByIdAsync(int friendId);
        Task SaveAsync(Friend friend);
    }
}