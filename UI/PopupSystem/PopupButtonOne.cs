using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PopupButtonOne : MonoBehaviour
{
    public int listOrder;
    void Update()
    {
        if (GameAttributes.activeClickedGameObject != null && listOrder<GameAttributes.activeClickedGameObject.GetComponent<GetItem>().item.popupList.popupList.Count)
        {
            GetComponent<RawImage>().texture = GameAttributes.activeClickedGameObject.GetComponent<GetItem>().item.popupList.popupList[listOrder].popupImage;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
    public void ButtonAction()
    {
        GameAttributes.activeClickedGameObject.GetComponent<GetItem>().item.popupList.popupList[listOrder].ButtonAction();
    }
}
