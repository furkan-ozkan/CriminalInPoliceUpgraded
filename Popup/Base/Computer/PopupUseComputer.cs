using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Popup/Base/Use Computer Popup")]
public class PopupUseComputer : Popup
{
    public override void ButtonAction()
    {
        base.ButtonAction();
        GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().monitor.SetActive(true);
    }
}
