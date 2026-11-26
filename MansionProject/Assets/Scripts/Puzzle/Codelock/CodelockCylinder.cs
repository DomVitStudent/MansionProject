using System;
using TMPro;
using UnityEngine;

public class CodelockCylinder : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI numberText;
    [SerializeField] private int maxNumber; 

    public int CurrentValue { get; private set; } = 0;

    public Action OnValueChanged;
    public void StepUp()
    {
    
        if (CurrentValue == maxNumber)
        {
            CurrentValue = 0;
        } 
        else
        {
            CurrentValue++;
        }
        UpdateVisuals();
        OnValueChanged.Invoke();
    } 
    public void StepDown()
    {
        if (CurrentValue == 0)
        {
            CurrentValue = maxNumber;
        }
        else
        {
            CurrentValue--;
        } 
        UpdateVisuals();
        OnValueChanged.Invoke();
    }
    private void UpdateVisuals()
    {
        numberText.text = CurrentValue.ToString(); 
    }
}
