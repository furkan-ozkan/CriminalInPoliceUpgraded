using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : ScriptableObject
{
    public string questsNameEn;
    public string questDescriptionEn;

    public string questsNameTr;
    public string questDescriptionTr;

    public bool done;
    public float reward;
    public int reputation;

    public virtual void DoneControl()
    {

    }
}

[CreateAssetMenu(menuName ="Quest/Quest1")]
public class Quest1 : Quest
{
    public override void DoneControl()
    {
        if (GameAttributes.houseOneHomeFreeTimes)
        {
            done = true;
        }
    }
}

[CreateAssetMenu(menuName = "Quest/Quest2")]
public class Quest2 : Quest
{
    public override void DoneControl()
    {
        if (GameAttributes.houseOneWifiPassword)
        {
            done = true;
        }
    }
}

[CreateAssetMenu(menuName = "Quest/Quest3")]
public class Quest3 : Quest
{
    public override void DoneControl()
    {
        if (GameAttributes.houseOneFrontDoorPassword)
        {
            done = true;
        }
    }
}