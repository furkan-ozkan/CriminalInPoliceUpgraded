using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetQuest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // delete this load code after create a main menu
        SaveSystem.LoadGame();
        FillQuestPanel();
    }
    public void FillQuestPanel()
    {
        StartCoroutine(QuestPanelFill());
    }
    IEnumerator QuestPanelFill()
    {
        yield return new WaitForSeconds(1);
        if (GameAttributes.lang)
        {
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().questName.text = GameAttributes.activeQuest.questsNameEn;
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().questDescription.text = GameAttributes.activeQuest.questDescriptionEn;
        }
        else
        {
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().questName.text = GameAttributes.activeQuest.questsNameTr;
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().questDescription.text = GameAttributes.activeQuest.questDescriptionTr;
        }
        GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().questReward.text = GameAttributes.activeQuest.reward.ToString();
        GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().questReputation.text = GameAttributes.activeQuest.reputation.ToString();
    }
}
