using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events; 



public class Interactable : MonoBehaviour //gjord av edward
{
    public List<string> interactDialogue;

    public static Action<List<string>> OnStart;
    public UnityEvent OnInteract; 


    public void Interact()
    {
        if (interactDialogue != null && interactDialogue.Count > 0)
        {
            OnStart?.Invoke(interactDialogue);
        }
        OnInteract.Invoke();
    } 
}
