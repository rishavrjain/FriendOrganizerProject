using FriendOrganizer.Model;
using System.Threading.Tasks;

namespace FriendOrganizerUI.Data.Repositories
{
    public interface IProgrammingLanguageRepository
        : IGenericRepository<ProgrammingLanguage>
    {
        Task<bool> IsReferencedByFriendAsync(int programmingLanguageId);
    }
}