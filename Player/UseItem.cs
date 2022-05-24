using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    void Update()
    {
        if (!GameAttributes.onPause)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.transform.GetComponent<GetItem>() && Input.GetMouseButtonDown(0))
                {
                    //GameAttributes.activeClickedItemPoint = hit.point;
                    if (hit.transform.GetComponent<GetItem>().item.usable)
                    {
                        Debug.Log(Vector3.Distance(hit.transform.position, transform.position));
                        if (Vector3.Distance(hit.transform.position,transform.position)< hit.transform.GetComponent<GetItem>().item.interractDistance)
                        {
                            GameAttributes.activeClickedGameObject = hit.transform.gameObject;
                            hit.transform.GetComponent<GetItem>().item.Use();
                        }
                        else
                        {
                            GameObject.FindGameObjectWithTag("Canvas").GetComponent<Anounce>().anounce(0.5f, "Too far");
                            if (GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().popupMenu.activeSelf)
                            {
                                GameObject.FindGameObjectWithTag("Canvas").GetComponent<PlayerCanMoveController>().CanMove();
                                GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().popupMenu.SetActive(false);
                            }
                        }
                    }
                    
                }
            }
        }
    }
}
