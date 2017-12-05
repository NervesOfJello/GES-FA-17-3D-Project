using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class InventoryMenu : MonoBehaviour {
    [SerializeField]
    private GameObject inventoryMenuPanel;

    [SerializeField]
    private FirstPersonController firstPersonController;

    private bool isMenuShowing
    {
        get { return inventoryMenuPanel.activeSelf; }
    }

    public List<InventoryObject> PlayerInventory { get; private set; }

    private void Awake()
    {
        PlayerInventory = new List<InventoryObject>();
    }

    // Use this for initialization
    void Start ()
    {
        HideMenu();
	}
    private void Update()
    {
        HandleInput();
        UpdateCursor();
    }

    private void HideMenu()
    {
        inventoryMenuPanel.SetActive(false);
        firstPersonController.enabled = true;
    }
    private void ShowMenu()
    {
        inventoryMenuPanel.SetActive(true);
        firstPersonController.enabled = false;
    }
    private void HandleInput()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (isMenuShowing)
                HideMenu();
            else
                ShowMenu();
        }
    }
    private void UpdateCursor()
    {
        if (isMenuShowing)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
