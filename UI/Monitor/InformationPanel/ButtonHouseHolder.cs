using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonHouseHolder : MonoBehaviour
{
    public HouseInformations house;
    public void FillInformationPanel()
    {
        UiController canvas = GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>();
        canvas.houseName.text = house.houseNo;
        if (GameAttributes.houseOneHomeFreeTimes)
        {
            canvas.freeTimes.text = house.freeTimeStart + " - " + house.freeTimeEnd;
            canvas.wifiPass.color = Color.black;
        }
        else
        {
            canvas.freeTimes.text = "Unknowen";
            canvas.wifiPass.color = Color.red;
        }

        canvas.citizenName.text = house.citizen.citizenName;

        if (GameAttributes.houseOneWifiPassword)
        {
            canvas.wifiPass.text = "Knowen";
            canvas.wifiPass.color = Color.green;
        }
        else
        {
            canvas.wifiPass.text = "Unknowen";
            canvas.wifiPass.color = Color.red;
        }
        if (GameAttributes.houseOneFrontDoorPassword)
        {
            canvas.doorPass.text = "Knowen";
            canvas.doorPass.color = Color.green;
        }
        else
        {
            canvas.doorPass.text = "Unknowen";
            canvas.doorPass.color = Color.red;
        }
    }
}
