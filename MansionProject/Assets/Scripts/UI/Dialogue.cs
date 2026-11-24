using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public static Dialogue instance { get; private set; }
    private TextMeshProUGUI TextBox;

  

    public void StartDialogue(List<string> dialogue)
    {
        gameObject.SetActive(true);
    }

    private void NextDialogue()
    { 
        
        gameObject.SetActive(true);
    }
    void Update()
    {
        
    }
}
