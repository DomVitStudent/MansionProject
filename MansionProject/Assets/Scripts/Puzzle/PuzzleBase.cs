using System;
using Unity.VisualScripting;
using UnityEngine;

public class PuzzleBase : MonoBehaviour
{
    public static Action OnPuzzleOpen;
    public static Action OnPuzzleClose;

    private void OnEnable()
    {
        Debug.Log("Opening puzzle");
        OnPuzzleOpen.Invoke();
    }
    private void OnDisable()
    {
        OnPuzzleClose.Invoke();
    }
}
