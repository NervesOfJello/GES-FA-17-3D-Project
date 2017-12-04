using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IActivatable {
    [SerializeField]
    private string nameText;

    private Animator animator;

    public string NameText
    {
        get
        {
            return nameText;
        }
    }

    // Use this for initialization
    void Start ()
    {
        animator = GetComponent<Animator>();
	}

    public void DoActivate()
    {
        animator.SetBool("isOpen", true);
    }
}
