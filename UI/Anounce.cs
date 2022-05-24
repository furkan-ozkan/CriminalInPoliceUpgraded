using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Anounce : MonoBehaviour
{
    public void anounce(float sec,string message)
    {
        StartCoroutine(showAnounce(sec,message));
    }
    IEnumerator showAnounce(float sec, string message)
    {
        GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().anounceTextfield.GetComponent<TextMeshProUGUI>().text = message;
        yield return new WaitForSeconds(sec);
        GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().anounceTextfield.GetComponent<TextMeshProUGUI>().text = "";
    }
}
