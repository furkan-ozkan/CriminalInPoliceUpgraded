using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WifiCrack : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F) && other.tag == "Player" && !GameAttributes.houseOneWifiPassword)
        {
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().wifiCrackPanel.SetActive(true);
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().WifiCracksSlider.GetComponent<GameAndFillBar>().SetWifiBar(.3f,.7f,5);
        }

        if (other.tag == "Player" && GameAttributes.wifiCracked)
        {
            GameAttributes.wifiCracked = false;
            GameAttributes.houseOneWifiPassword = true;
            gameObject.SetActive(false);
        }
    }
}
