using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAttributes : MonoBehaviour
{
    // --------------------------- Tech ----------------------------------
    public static bool lang = true;

    public static GameObject activeClickedGameObject;
    public static Vector3 activeClickedPoint;
    public static Vector3 activeClickedItemPoint;

    public static GameObject activeLookingGameObject;
    public static GameObject lastLookingGameObject;

    public static Quest activeQuest = GameObject.FindGameObjectWithTag("GameController").GetComponent<QuestList>().questList[1];
    public static int activeQuestListNum=1;

    public static bool canMove = true;
    public static bool onPause = false;

    public static bool walking = false;

    public static int hour=11;
    public static int day=1;
    public static bool updateDirectly = false;
    // --------------------------- Player Attributes ---------------------
    public static float money = 100;
    public static int reputation = 0;

    // --------------------------- Quests --------------------------------
    public static bool wifiCracked=false;
        // ----------House 1------
        public static bool houseOneHomeFreeTimes;
        public static int house1InvestPoints=0;
        public static bool houseOneWifiPassword;
        public static bool houseOneFrontDoorPassword;

}
