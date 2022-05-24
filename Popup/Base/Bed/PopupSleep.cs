using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Popup/Base/SleepPopup")]
public class PopupSleep : Popup
{
    public override void ButtonAction()
    {
        SaveSystem.SaveGame();
        GameAttributes.hour += 6;
        GameAttributes.updateDirectly = true;
        base.ButtonAction();
    }
}
