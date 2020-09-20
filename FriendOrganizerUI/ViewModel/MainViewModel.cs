using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using FriendOrganizer.Model;
using FriendOrganizerUI.Data;

namespace FriendOrganizerUI.ViewModel
{
    public class MainViewModel: ViewModelBaseClass
    {
        private IFriendDataService _friendDataService;
        private Friend _selectedFriend;

        public MainViewModel(IFriendDataService friendDataService)
        {
            Friends = new ObservableCollection<Friend>();
            _friendDataService = friendDataService;
        }

        public async Task LoadAsync()
        {
            var friends = await _friendDataService.GetAllAsync();
            Friends.Clear();
            foreach(var friend in friends)
            {
                Friends.Add(friend);
            }
        }

        public ObservableCollection<Friend> Friends { get; set; }

        public Friend SelectedFriend
        {
            get { return _selectedFriend; }
            set 
            { 
                _selectedFriend = value;
                OnPropertyChanged();
            }
        }

    }
}
