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
        SenceSlider.value = PlayerCamera.xSence;
        SenceInput.text = PlayerCamera.xSence.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeXSence()
    {
        PlayerCamera.xSence = SenceSlider.value;
        PlayerCamera.ySence = SenceSlider.value;
        SenceSlider.value = PlayerCamera.xSence;
        SenceInput.text = PlayerCamera.xSence.ToString();
    }
    public void ChangeXSenceEnter()
    {
        PlayerCamera.xSence = float.Parse("000" + SenceInput.text);
        PlayerCamera.ySence = float.Parse("000" + SenceInput.text);
        SenceInput.text = PlayerCamera.xSence.ToString();
        SenceSlider.value = PlayerCamera.xSence;
    }
}
