using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NtMB.Language
{
    public class Language
    {
        //static labels' text
        public string LanguageName {get; set;}
        public string BotState { get; set; }
        public string ConnectedProcesses { get; set; }
        public string ConnectedOtherBots { get; set; }
        public string Messages { get; set; }
        public string SelectedBotType { get; set; }

        //changeable text
        public string Uninitialized { get; set; }
        public string Initialized { get; set; }
        public string Minigames_ON { get; set; }
        public string Minigames_OFF { get; set; }
        public string BotTypeMinigames { get; set; }
        public string BotTypeExp { get; set; }
        public string BotTypeMoving { get; set; }
        public string BotTypeTrade { get; set; }
        public string BotTypeEvent { get; set; }
        public string BotTypeTS { get; set; }
        public string BotTypeCustom { get; set; }

        public void SetDefaultEng()
        {
            //ststic labels' text
            LanguageName = "English";
            BotState = "Bot state:";
            ConnectedProcesses = "Connected processes:";
            ConnectedOtherBots = "Connected other bots:";
            Messages = "Messages:";
            SelectedBotType = "Selected Bot type:";
            //changeable text
            Uninitialized = "< uninitialized >";
            Initialized = "< initialized >";
            Minigames_ON = "< minigame bot ON >";
            Minigames_OFF = "< minigame bot OFF >";
            BotTypeMinigames = "Minigames Bot";
            BotTypeExp = "Exp Bot";
            BotTypeMoving = "Moving Bot";
            BotTypeTrade = "Trade Bot";
            BotTypeEvent = "Event Bot";
            BotTypeTS = "Timespace Bot";
            BotTypeCustom = "Custom Bot";
        }
    }
}
