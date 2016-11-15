using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.Core.Plugins;
using Steamworks;
using UnityEngine;
using Rocket.Unturned.Player;
using Rocket.Unturned.Chat;
using Rocket.API.Collections;
using System.Timers;
using Rocket.Unturned.Events;
using Rocket.Unturned;
using SDG.Unturned;

namespace UrlOnJoin
{
    public class Plugin : RocketPlugin<PluginConfiguration>
    {
        private static Plugin Instance;
        protected override void Load()
        {
            Instance = this;
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
        }

        private void Events_OnPlayerConnected(UnturnedPlayer player)
        {
            player.Player.channel.send("askBrowserRequest", player.CSteamID, ESteamPacket.UPDATE_RELIABLE_BUFFER, Configuration.Instance.description, Configuration.Instance.url);
        }

        protected override void Unload()
        {
            U.Events.OnPlayerConnected -= Events_OnPlayerConnected;
        }

        #region translations
        public override TranslationList DefaultTranslations
        {
            get
            {
                return new TranslationList() {
                    {"",""},
                };
            }
        }
        #endregion
    }
}
