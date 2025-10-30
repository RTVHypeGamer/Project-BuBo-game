using UnityEngine;
using System;


public class DialogueEvent
{
    public event Action<string> OnEnterDialogue;

    public void EnterDialogue(string knotName)
    {
        if (OnEnterDialogue != null)
        {
            OnEnterDialogue(knotName);
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
