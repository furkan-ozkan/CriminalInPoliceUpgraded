using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupMenuPıc : MonoBehaviour
{
    void Update()
    {
        if(GameAttributes.activeClickedGameObject != null)
        {
            GetComponent<RawImage>().texture = GameAttributes.activeClickedGameObject.GetComponent<GetItem>().item.popupList.popupImage;
        }
    }

}
