﻿namespace TwitchLib.Events.Services.LiveStreamMonitor
{
    #region using directives
    using System;

    using Enums;
    #endregion
    /// <summary>Class representing event args for OnChannelOffline event.</summary>
    public class OnStreamOfflineArgs : EventArgs
    {
        /// <summary>Event property representing channel that has gone offline.</summary>
        public string Channel;
        /// <summary>Event property representing how channels IDs are represented.</summary>
        public StreamIdentifierType IdentifierType;
        /// <summary>Event property representing seconds between queries to Twitch Api.</summary>
        public int CheckIntervalSeconds;
    }
}
