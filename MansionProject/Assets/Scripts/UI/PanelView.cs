using System;
using UnityEngine;

public class PanelView : MonoBehaviour
{
    public static Action OnPanelOpen;
    public static Action OnPanelClose;
    private void OnEnable()
    {
        Debug.Log("Opening puzzle");
        OnPanelOpen.Invoke();
    }
    private void OnDisable()
    {
        OnPanelClose.Invoke();
    }
}
