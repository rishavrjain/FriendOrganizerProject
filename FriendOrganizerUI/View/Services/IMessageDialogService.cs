namespace FriendOrganizerUI.View.Services
{
    public interface IMessageDialogService
    {
        MessageDialogResult ShowOkCancelResult(string text, string title);
    }
}