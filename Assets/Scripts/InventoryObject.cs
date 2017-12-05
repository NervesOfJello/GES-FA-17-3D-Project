using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : MonoBehaviour, IActivatable {
    [SerializeField]
    private string nameText;
    [SerializeField]
    private string descriptionText;

    private MeshRenderer meshRenderer;
    private Collider collider;
    private List<InventoryObject> playerInventory;

    public string NameText
    {
        get
        {
            return nameText;
        }
    }

    public void DoActivate()
    {
        //add to inventory Menu
        playerInventory.Add(this);
        //remove from 3D world
        meshRenderer.enabled = false;
        collider.enabled = false;
        throw new System.NotImplementedException();
    }
    
    // Use this for initialization
    void Start ()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        collider = GetComponent<Collider>();
        playerInventory = FindObjectOfType<InventoryMenu>().PlayerInventory;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
