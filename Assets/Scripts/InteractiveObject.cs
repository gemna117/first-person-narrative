using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour, IInteractive
{
    [SerializeField]
    private string displayText = nameof(InteractiveObject);

    public string displaytext => displayText;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void InteractWith()
    {
        try
        {

        audioSource.Play();
        }
        catch (System.Exception)
        {
            throw now System.Exception("missing audio source component.");
        }
        Debug.Log($"player just interacted with {gameObject.name}.");
    }
}
