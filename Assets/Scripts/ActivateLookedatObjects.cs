using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateLookedatObjects : MonoBehaviour {
    [SerializeField]
    private float maxActivateDistance = 10;
    [SerializeField]
    private Text lookedAtObjectText;

    private IActivatable objectLookedAt;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        UpdateObjectLookedAt();
        UpdateLookedAtObjectText();
        HandleInput();
	}

    private void UpdateObjectLookedAt()
    {
        //make raycast visible in scene view
        Debug.DrawRay(transform.position, transform.forward * maxActivateDistance, Color.blue);
        //use this RaycastHit variable to temporarily store data on the object hit
        RaycastHit raycastHit;

        //if a raycast hits something
        if (Physics.Raycast(transform.position, transform.forward, out raycastHit, maxActivateDistance))
        {
            Debug.Log("Raycast hit " + raycastHit.transform.name);

            objectLookedAt = raycastHit.transform.GetComponent<IActivatable>();
        }
        else
        {
            objectLookedAt = null;
        }
    }

    private void HandleInput()
    {
        if (objectLookedAt != null && Input.GetButtonDown("Activate"))
        {
            objectLookedAt.DoActivate();
        }
    }

    private void UpdateLookedAtObjectText()
    {
        if (objectLookedAt == null)
        {
            lookedAtObjectText.text = string.Empty;
        }
        else
        {
            lookedAtObjectText.text = objectLookedAt.NameText;
        }
        //functionally identical alternate syntax for reference:
        //lookedAtObjectText.text = objectLookedAt == null ? string.Empty : objectLookedAt.NameText
    }
}
