﻿using Prism.Events;

namespace FriendOrganizerUI.Events
{
    public class AfterFriendSavedEvent:PubSubEvent<AfterFriendSavedEventArgs>
    {
    }

    public class AfterFriendSavedEventArgs
    {
        public int Id { get; set; }
        public string DisplayMember { get; set; }
    }
}
