using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCamera : MonoBehaviour
{
    public Transform yAxis;
    public Transform xAxis;
    public static float xSence = 300.0f;
    public static float ySence = 300.0f;
    public float limitXAxizAngle = 30;
    private Vector3 mXAxiz;
    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        mXAxiz = xAxis.localEulerAngles;
        
    }
    private void cameraFPS(){
        float xCamera = Input.GetAxis("Mouse X") * -xSence * Time.deltaTime;
        yAxis.transform.Rotate(0, -xCamera, 0);

        float yCamera = Input.GetAxis("Mouse Y") * -ySence * Time.deltaTime;
        var x = mXAxiz.x + yCamera;
        if (x >= -limitXAxizAngle && x <= limitXAxizAngle){
            mXAxiz.x = x;
            xAxis.localEulerAngles = mXAxiz;
        }

        if(GameManager.timeStop == true)
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
    void Update(){
        cameraFPS();
    }

}
