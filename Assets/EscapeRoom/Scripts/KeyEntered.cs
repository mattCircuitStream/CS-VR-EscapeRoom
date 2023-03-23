using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyEntered : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private string animTrigger;

    public void KeyEnter()
    {
        animator.SetTrigger(animTrigger);
    }
}
