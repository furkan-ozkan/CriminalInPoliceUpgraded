using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public RuntimeAnimatorController walkAnim, idleAnim;
    void Update()
    {
        if (GameAttributes.walking)
        {
            gameObject.GetComponent<Animator>().runtimeAnimatorController = walkAnim;
        }
        else
        {
            gameObject.GetComponent<Animator>().runtimeAnimatorController = idleAnim;
        }
    }
}
