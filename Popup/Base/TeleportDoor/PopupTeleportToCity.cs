using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(menuName = "Popup/Base/TeleportDoorPopup")]
public class PopupTeleportToCity : Popup
{
    public override void ButtonAction()
    {
        base.ButtonAction();
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>().navMeshAgent.Warp(new Vector3(18.7f, 0.3f, 88));
        GameAttributes.walking = false;
    }
}
