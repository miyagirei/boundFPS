using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{
    public Slider SenceSlider;
    public InputField SenceInput;


    void Start()
    {
        SenceSlider.value = playerCamera.xSence;
        SenceInput.text = playerCamera.xSence.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeXSence()
    {
        playerCamera.xSence = SenceSlider.value;
        playerCamera.ySence = SenceSlider.value;
        SenceSlider.value = playerCamera.xSence;
        SenceInput.text = playerCamera.xSence.ToString();
    }
    public void ChangeXSenceEnter()
    {
        playerCamera.xSence = float.Parse("000" + SenceInput.text);
        playerCamera.ySence = float.Parse("000" + SenceInput.text);
        SenceInput.text = playerCamera.xSence.ToString();
        SenceSlider.value = playerCamera.xSence;
    }
}
