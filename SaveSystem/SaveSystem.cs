using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem : MonoBehaviour
{
    public static void SaveGame()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/save.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        SaveData data = new SaveData();

        formatter.Serialize(stream,data);
        stream.Close();
    }
    public static void LoadGame()
    {
        string path = Application.persistentDataPath + "/save.save";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SaveData data = formatter.Deserialize(stream) as SaveData;
            stream.Close();

            // injure in game in here
            InjureLoad(data);
        }
        else
        {
            //Debug.LogError("Save file not found!");
        }
    }
    private static void InjureLoad(SaveData data)
    {
        GameAttributes.day = data.day;

        // --------------------------- Quests --------------------------------
            // ----------House 1------
            GameAttributes.activeQuestListNum = data.activeQuestListNum;

            GameAttributes.houseOneHomeFreeTimes = data.houseOneHomeFreeTimes;
            GameAttributes.houseOneWifiPassword = data.houseOneWifiPassword;
            GameAttributes.houseOneFrontDoorPassword = data.houseOneFrontDoorPassword;

        // ------------------------------- Final Part ---------------------------

        if(GameObject.FindGameObjectWithTag("GameController").GetComponent<QuestList>().questList.Count >= GameAttributes.activeQuestListNum)
            GameAttributes.activeQuest = GameObject.FindGameObjectWithTag("GameController").GetComponent<QuestList>().questList[GameAttributes.activeQuestListNum];
    }
}
