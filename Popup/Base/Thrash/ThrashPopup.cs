using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Popup/Base/CleanThrashPopup")]
public class ThrashPopup : Popup
{
    public override void ButtonAction()
    {
        base.ButtonAction();
        GameAttributes.activeClickedGameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("GameController").GetComponent<ShowParticle>().ParticleShow(0,GameAttributes.activeClickedGameObject.transform.position);
    }
}
