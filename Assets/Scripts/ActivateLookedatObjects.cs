using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLookedatObjects : MonoBehaviour {
    [SerializeField]
    private float maxActivateDistance = 10;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.DrawRay(transform.position, transform.forward * maxActivateDistance, Color.blue);

        RaycastHit raycastHit;

        if (Physics.Raycast(transform.position, transform.forward, out raycastHit, maxActivateDistance))
        {
            Debug.Log("Raycast hit " + raycastHit.transform.name);

            IActivatable objectLookedAt = raycastHit.transform.GetComponent<IActivatable>();

            if (objectLookedAt != null && Input.GetButtonDown("Activate"))
            {
                objectLookedAt.DoActivate();
            }
        }
	}
}
