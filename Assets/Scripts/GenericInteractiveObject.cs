using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericInteractiveObject : MonoBehaviour, IActivatable {
    
    public void DoActivate()
    {
        Debug.Log(transform.name + " was activated!");
    }
}
