using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCanMoveController : MonoBehaviour
{
    public void CantMove()
    {
        GameAttributes.canMove = false;
        if (GameAttributes.activeClickedGameObject.GetComponent<GetItem>().item.popupList.popupList[gameObject.GetComponent<PopupButtonOne>().listOrder].descriptipn != "")
        {
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().pupupDescription.transform.position = gameObject.transform.position + new Vector3(100, 80, 0);
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().pupupDescription.SetActive(true);
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().pupupDescription.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text =
                GameAttributes.activeClickedGameObject.GetComponent<GetItem>().item.popupList.popupList[gameObject.GetComponent<PopupButtonOne>().listOrder].descriptipn;
        }
    }
    public void CanMove()
    {
        GameAttributes.canMove = true;
        GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().pupupDescription.SetActive(false);
    }
    public void CantMoveGeneral()
    {
        GameAttributes.canMove = false;
    }
    public void CanMoveGeneral()
    {
        GameAttributes.canMove = true;  
    }
}
