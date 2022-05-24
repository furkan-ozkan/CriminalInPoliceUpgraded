using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    #region all attributes
    // -------------------- Popup System --------------------------
    public GameObject popupMenu,button1,button2,button3,button4,button5;
    public Texture nullImage;
    // -------------------- Popup System --------------------------
    #region Monitor System
    // -------------------- Monitor System --------------------------
    public GameObject monitor;
    public GameObject pupupDescription;
    // -------------------- Quest Panel System --------------------------
    public GameObject questPanel;
    public TextMeshProUGUI questName;
    public TextMeshProUGUI questDescription;
    public TextMeshProUGUI questReward;
    public TextMeshProUGUI questReputation;
    // -------------------- Quest Panel System --------------------------

    // -------------------- Information Panel System --------------------------
    public GameObject informationPanel;
    public GameObject housePanel;
    public TextMeshProUGUI houseName;
    public TextMeshProUGUI citizenName;
    public TextMeshProUGUI freeTimes;
    public TextMeshProUGUI wifiPass;
    public TextMeshProUGUI doorPass;
    // -------------------- Information Panel System --------------------------

    // -------------------- Buyazon Panel System --------------------------
    public GameObject buyazonPanel;
    // -------------------- Buyazon Panel System --------------------------
    
    // -------------------- Skill Panel System --------------------------
    public GameObject skillPanel;
    // -------------------- Skill Panel System --------------------------
    // -------------------- Monitor System --------------------------
    #endregion
    
    // -------------------- Wifi Crack System --------------------------
    public GameObject wifiCrackPanel;
    public Slider WifiCracksSlider;
    // -------------------- Wifi Crack System --------------------------
    
    // -------------------- General UI System --------------------------
    public GameObject anounceTextfield;
    public Slider prograssBar;
    // -------------------- General UI System --------------------------

    #endregion
    #region start update
    // -------------------- Update -------------------------------------
    private void Update()
    {
        if (monitor.activeSelf) { GameAttributes.onPause = true;}
        if(Input.GetKeyDown(KeyCode.Escape)) {CloseWifiCrackPanel();}
        
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>().navMeshAgent.Warp(new Vector3(64.2600021f, -9.53674316e-06f, 323.209991f));
            GameAttributes.walking = false;
        }
    }
    // -------------------- Update -------------------------------------
    #endregion
    #region general metods
    // -------------------- General Metods -------------------------------------
    public void UpdateFillBar(float min,float max, float now)
    {
        prograssBar.gameObject.SetActive(true);
        prograssBar.GetComponent<ProgressBar>().FillBar(min, max, now);
    }
    public void HideFillBar()
    {
        prograssBar.gameObject.SetActive(false);
    }
    // -------------------- General Metods -------------------------------------
    #endregion
    #region monitor buttons and metods
    // -------------------- Monitor Buttons -------------------------------
    public void OpenQuestPanel()
    {

        questPanel.SetActive(true);
    }
    public void CloseQuestPanel()
    {
        questPanel.SetActive(false);
    }
    public void OpenInformationPanel()
    {
        informationPanel.SetActive(true);
    }
    public void CloseInformationPanel()
    {
        informationPanel.SetActive(false);
    }
    public void OpenBuyazonPanel()
    {
        buyazonPanel.SetActive(true);
    }
    public void CloseBuyazonPanel()
    {
        buyazonPanel.SetActive(false);
    }
    public void OpenSkillPanel()
    {
        skillPanel.SetActive(true);
    }
    public void CloseSkillPanel()
    {
        skillPanel.SetActive(false);
    }
    public void OpenHousePanel()
    {
        housePanel.SetActive(true);
    }
    public void CloseHousePanel()
    {
        housePanel.SetActive(false);
    }

    public void CloseComputer()
    {
        monitor.SetActive(false);
        GameAttributes.onPause = false;
    }
    public void QuestDoneButton()
    {
        if (GameAttributes.activeQuest.done)
        {
            GameAttributes.reputation += GameAttributes.activeQuest.reputation;
            GameAttributes.money += GameAttributes.activeQuest.reward;
            GameAttributes.activeQuestListNum++;
            if (GameAttributes.activeQuestListNum < GameObject.FindGameObjectWithTag("GameController").GetComponent<QuestList>().questList.Count)
                GameAttributes.activeQuest = GameObject.FindGameObjectWithTag("GameController").GetComponent<QuestList>().questList[GameAttributes.activeQuestListNum];
            gameObject.GetComponent<GetQuest>().FillQuestPanel();
        }
    }
    public void CheatButton()
    {
        GameAttributes.activeQuest.done = true;
    }
    #endregion

    #region Wifi Crack System

    public void CloseWifiCrackPanel()
    {
        wifiCrackPanel.SetActive(false);
    }

    #endregion
}
