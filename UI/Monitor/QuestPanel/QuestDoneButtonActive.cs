using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestDoneButtonActive : MonoBehaviour
{
    void Update()
    {
        GameAttributes.activeQuest.DoneControl();
        if (GameAttributes.activeQuest.done)
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
        else
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
    }
}
