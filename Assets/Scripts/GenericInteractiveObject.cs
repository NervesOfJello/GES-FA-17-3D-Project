using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericInteractiveObject : MonoBehaviour, IActivatable {

    [SerializeField]
    string nametext;

    public string NameText
    {
        get
        {
            return nametext;
        }
    }

    public void DoActivate()
    {
        Debug.Log(transform.name + " was activated!");
    }
}
