using UnityEngine;
using UnityEngine.UI;

public class GameAndFillBar : MonoBehaviour
{
    private Slider slider;
    private float now=0;
    private float timer = 0;
    private float min, max;
    private float hardness;
    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            now += Time.deltaTime;
        }
        else
        {
            if(now>=0)
                now -= Time.deltaTime;
        }

        if (now > min && now < max)
        {
            timer += Time.deltaTime;
        }
        else
        {
            if(timer>=0)
                timer -= Time.deltaTime;
        }

        if (timer >= hardness)
        {
            GameAttributes.wifiCracked = true;
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().HideFillBar();
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().wifiCrackPanel.SetActive(false);
        }
        
        slider.value = Mathf.InverseLerp(0,1,now);
        if(GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().wifiCrackPanel.activeSelf)
            GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().UpdateFillBar(hardness,0,timer);
        
    }

    public void SetWifiBar(float min, float max, float hardness)
    {
        this.min = min;
        this.max = max;
        this.hardness = hardness;
    }
}
