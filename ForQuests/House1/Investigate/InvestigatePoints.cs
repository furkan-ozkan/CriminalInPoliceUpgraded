using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvestigatePoints : MonoBehaviour
{
    [SerializeField][Range(0, 10)] private float investTime;
    private float time;
    private void Start()
    {
        time = investTime;
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F) && other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().UpdateFillBar(0, investTime, time);
            this.time -= Time.deltaTime;
            if (time <= 0)
            {
                GameAttributes.house1InvestPoints++;
                if (GameAttributes.house1InvestPoints == 3)
                    GameAttributes.houseOneHomeFreeTimes = true;
                GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().HideFillBar();
                GameAttributes.hour += 8;
                GameAttributes.updateDirectly = true;
                gameObject.SetActive(false);
            }
        }
        else
        {
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().HideFillBar();
        }
    }
}
