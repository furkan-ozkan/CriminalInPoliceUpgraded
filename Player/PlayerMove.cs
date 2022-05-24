using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (!GameAttributes.onPause)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 100) && !hit.transform.GetComponent<GetItem>() && GameAttributes.canMove)
                {
                    navMeshAgent.SetDestination(hit.point);
                    GameAttributes.activeClickedPoint = hit.point;
                    GameAttributes.walking = true;
                    GameObject.FindGameObjectWithTag("Canvas").GetComponent<UiController>().popupMenu.SetActive(false);
                }

            }
        }
        if (gameObject.transform.position.x == GameAttributes.activeClickedPoint.x && gameObject.transform.position.z == GameAttributes.activeClickedPoint.z)
        {
            GameAttributes.walking = false;
        }

    }
}
