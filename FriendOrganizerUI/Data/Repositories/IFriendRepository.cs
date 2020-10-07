using FriendOrganizer.Model;

namespace FriendOrganizerUI.Data.Repositories
{

    public interface IFriendRepository : IGenericRepository<Friend>
    { 
        void RemovePhoneNumber(FriendPhoneNumber model);
    }
}