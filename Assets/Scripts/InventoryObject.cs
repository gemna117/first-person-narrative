using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : InteractiveObject
{
    [SerializeField]
    private string description;

    [SerializeField]
    public string objectName;

    private new Renderer renderer;
    private new Collider collider;

    public void Start()
    {
        renderer = GetComponent<Renderer>();
        collider = GetComponent<Collider>();
    }
    public InventoryObject()
    {
        displaytext = $"Take {objectName}";
    }

    public override void InteractWith()
    {
        base.InteractWith();
        PlayerInventory.inventoryObjects.Add(this);
        GetComponent<Renderer>().enabled = false;
        renderer.enabled = false;
        collider.enabled = false;
    }
}
