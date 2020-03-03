using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithLookedAt : MonoBehaviour
{
    [SerializeField]
    private DetectLookedAtInteractive detectLookedAtInteractive;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("interact") && detectLookedAtInteractive.LookedAtInteractive != null)
        {
            Debug.Log("player pressed the interact button.");
            detectLookedAtInteractive.LookedAtInteractive.InteractWith();
            detectLookedAtInteractive.LookedAtInteractive.InteractWith();
        }
    }
}
