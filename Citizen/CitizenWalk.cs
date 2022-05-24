using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CitizenWalk : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    public Citizen citizen;
    public List<Vector3> walkPath;
    private int walkIndex = 0;
    private bool onceTrigger = false;
    private bool onceTriggerForEdge = false;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (!GameAttributes.onPause)
        {
            if (GameAttributes.hour>= citizen.walkTimeStart && GameAttributes.hour < citizen.walkTimeEnd)
            {
                if (!onceTrigger)
                {
                    onceTrigger = true;
                    navMeshAgent.Warp(walkPath[walkIndex]);
                    walkIndex++;
                }
                if (gameObject.transform.position.x != walkPath[walkIndex].x || gameObject.transform.position.z != walkPath[walkIndex].z)
                {
                    if (!onceTriggerForEdge)
                    {
                        navMeshAgent.SetDestination(walkPath[walkIndex]);
                    }
                }
                else if(walkIndex<walkPath.Count-1)
                {
                    walkIndex++;
                }
                if (gameObject.transform.position.x == walkPath[walkIndex].x && gameObject.transform.position.z == walkPath[walkIndex].z && walkIndex == walkPath.Count-1)
                {
                    GameObject.FindGameObjectWithTag("GameController").GetComponent<ShowParticle>().ParticleShow(0, gameObject.transform.position);
                    navMeshAgent.Warp(new Vector3(595.799988f, 0f, -596.400024f));
                    onceTriggerForEdge = true;
                }
            }
            if(GameAttributes.hour >= citizen.walkTimeEnd)
            {
                if (onceTrigger)
                {
                    onceTrigger = false;
                    navMeshAgent.Warp(walkPath[walkIndex]);
                    walkIndex--;
                }
                if (gameObject.transform.position.x != walkPath[walkIndex].x || gameObject.transform.position.z != walkPath[walkIndex].z)
                {
                    if (onceTriggerForEdge)
                    {
                        navMeshAgent.SetDestination(walkPath[walkIndex]);
                    }
                }
                else if(walkIndex>0)
                {
                    walkIndex--;
                }
                if (gameObject.transform.position.x == walkPath[walkIndex].x && gameObject.transform.position.z == walkPath[walkIndex].z && walkIndex == 0)
                {
                    GameObject.FindGameObjectWithTag("GameController").GetComponent<ShowParticle>().ParticleShow(0, gameObject.transform.position);
                    navMeshAgent.Warp(new Vector3(595.799988f, 0f, -596.400024f));
                    onceTriggerForEdge = false;
                }
            }
        }
        if (gameObject.transform.position.x == GameAttributes.activeClickedPoint.x && gameObject.transform.position.z == GameAttributes.activeClickedPoint.z)
        {
            GameAttributes.walking = false;
        }

    }
}
