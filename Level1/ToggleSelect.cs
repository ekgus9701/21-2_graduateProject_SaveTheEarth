using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSelect : MonoBehaviour
{
   
    public Toggle selectedToggle;

    public Transform food;
    public Transform plate;

    private void Start()
    {
        selectedToggle.onValueChanged.AddListener(delegate
        {
            ToggleValueChangedOccured(selectedToggle);
        });
    }

    void ToggleValueChangedOccured(Toggle tglValue)
    {
        Debug.Log("your current toggle state is: " + tglValue.isOn);
        if (tglValue.isOn == true)
        {
            Toggles.totalToggle += 1;
            food.gameObject.SetActive(true);
            plate.gameObject.SetActive(true);
        }
        else
        {
            Toggles.totalToggle -= 1;
            food.gameObject.SetActive(false);
            plate.gameObject.SetActive(true);
        }
        Debug.Log("your total is: " + Toggles.totalToggle);
    }

}
