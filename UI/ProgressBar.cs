using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public void FillBar(float min,float max , float now)
    {
        GetComponent<Slider>().value = Mathf.InverseLerp(max,min,now);
    }
}
