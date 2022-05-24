using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : ScriptableObject
{
    public string itemNameEn;
    public string itemNameTr;
    [Range(2,20)]public float interractDistance;
    public bool usable;
    public PopupList popupList;

    public virtual void Use()
    {
        GameObject canvas = GameObject.FindGameObjectWithTag("Canvas");
        canvas.GetComponent<UiController>().popupMenu.SetActive(false);
        canvas.GetComponent<UiController>().popupMenu.SetActive(true);
        canvas.GetComponent<UiController>().button1.GetComponent<RawImage>().texture = canvas.GetComponent<UiController>().nullImage;
        canvas.GetComponent<UiController>().button1.SetActive(true);
        canvas.GetComponent<UiController>().button2.GetComponent<RawImage>().texture = canvas.GetComponent<UiController>().nullImage;
        canvas.GetComponent<UiController>().button2.SetActive(true);
        canvas.GetComponent<UiController>().button3.GetComponent<RawImage>().texture = canvas.GetComponent<UiController>().nullImage;
        canvas.GetComponent<UiController>().button3.SetActive(true);
        canvas.GetComponent<UiController>().button4.GetComponent<RawImage>().texture = canvas.GetComponent<UiController>().nullImage;
        canvas.GetComponent<UiController>().button4.SetActive(true);
        canvas.GetComponent<UiController>().button5.GetComponent<RawImage>().texture = canvas.GetComponent<UiController>().nullImage;
        canvas.GetComponent<UiController>().button5.SetActive(true);
    }
}
