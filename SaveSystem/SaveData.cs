using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public int day;

    public int activeQuestListNum;

    public bool houseOneHomeFreeTimes;
    public bool houseOneWifiPassword;
    public bool houseOneFrontDoorPassword;
    public SaveData()
    {
        day = GameAttributes.day;

        // ----------------------------------- Quests ----------------------------
            // ----------House 1------
            activeQuestListNum = GameAttributes.activeQuestListNum;

            houseOneHomeFreeTimes = GameAttributes.houseOneHomeFreeTimes;
            houseOneWifiPassword = GameAttributes.houseOneWifiPassword;
            houseOneFrontDoorPassword = GameAttributes.houseOneFrontDoorPassword;
    }
}
