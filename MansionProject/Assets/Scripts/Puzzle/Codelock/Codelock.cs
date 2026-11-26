using System;
using UnityEngine;

public class Codelock : PuzzleBase
{
    [SerializeField] private int[] correctCode = { 1, 2, 3 };
    [SerializeField] private CodelockCylinder[] cylinders;

    private void Start()
    {
        foreach (var c in cylinders)
        {
            c.OnValueChanged += CheckCode;
        }
    }
    private void CheckCode()
    {
        for (int i = 0; i < cylinders.Length; i++)
        { 
            if (cylinders[i].CurrentValue != correctCode[i])
            {
                return;
            } 
        }  
        CompletePuzzle();

    }
    protected override void CompletePuzzle()
    {
        Debug.Log("win");
        base.CompletePuzzle();
      
    }
}
