using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour
{
    [Header("1 hours = x Sec")][SerializeField] [Range(2,60)] private float hourTime;
    private float time;
    private void Start()
    {
        time = hourTime;
        gameObject.transform.eulerAngles = new Vector3(GameAttributes.hour * 15 - 90, 90, 0);
    }
    void Update()
    {
        if (!GameAttributes.onPause)
        {
            time -= Time.deltaTime;
            if (time<0)
            {
                GameAttributes.hour++;
                if (GameAttributes.hour >= 24)
                {
                    GameAttributes.day++;
                    GameAttributes.hour -= 24;
                }
                gameObject.transform.eulerAngles = new Vector3(GameAttributes.hour*15-90,90,0);
                time = hourTime;
            }
            if (GameAttributes.updateDirectly)
            {
                gameObject.transform.eulerAngles = new Vector3(GameAttributes.hour * 15 - 90, 90, 0);
                GameAttributes.updateDirectly = false;
            }
        }
    }
}
