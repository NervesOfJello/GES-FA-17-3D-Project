using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour, IActivatable{
    [SerializeField]
    private string nameText;
    private bool isLightOn = false;
    private Light closetLight;

    public string NameText
    {
        get
        {
            return nameText;
        }
    }

    public void DoActivate()
    {
        if (isLightOn)
        {
            closetLight.enabled = false;
            isLightOn = false;
        }
        else
        {
            closetLight.enabled = true;
            isLightOn = true;
        }
    }

    // Use this for initialization
    void Start ()
    {
        closetLight = GetComponentInChildren<Light>();
        closetLight.enabled = false;
	}
}
