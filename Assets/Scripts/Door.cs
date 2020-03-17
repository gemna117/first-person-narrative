using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : InteractiveObject
{
    private Animator animator;
    private bool isOpen;

    public Door()
    {
        displaytext = nameof(Door);
    }

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public override void InteractWith()
    {
        if (isOpen)
        {
        base.InteractWith();
        animator.SetBool("shouldOpen", true);
            displaytext = string.Empty;
            isOpen = true;

        }
    }
}
