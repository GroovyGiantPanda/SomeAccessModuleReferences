﻿namespace TwitchLib.Extensions.Client
{
    /// <summary>Extension implementing reply to previous whisper functionality.</summary>
    public static class ReplyWhisperExt
    {
        /// <summary>SendWhisper wrapper method that will send a whisper back to the user who most recently sent a whisper to this bot.</summary>
        public static void ReplyToLastWhisper(this TwitchClient client, string message = "", bool dryRun = false)
        {
            if (client.PreviousWhisper != null)
                client.SendWhisper(client.PreviousWhisper.Username, message, dryRun);
        }
    }
}
