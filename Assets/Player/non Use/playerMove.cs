using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class playerMove : MonoBehaviour{
    //private Rigidbody rB;
    public float mainSpeed = 3.0f;

    [SerializeField] GameObject bullet = null;
    Transform bullets;
    public Transform muzzlePoint;
    public Transform headRotation;
    public float muzzleRoF = 3.0f;
    
    void Start(){
        //rB = GetComponent<Rigidbody>();
        bullets = new GameObject("PlayerBullerts").transform;
    }
    void Update(){
        characterMove();
        if(Input.GetKey(KeyCode.Mouse0)){
            DelayTime();
            InstBullet(muzzlePoint.transform.position, muzzlePoint.transform.rotation);
            //DelayTime();
        }
    }
    private void characterMove(){
        Transform trans = transform;
        transform.position = trans.position;
        trans.position += trans.TransformDirection(Vector3.forward) * Input.GetAxis("Vertical") * mainSpeed;
        trans.position += trans.TransformDirection(Vector3.right) * Input.GetAxis("Horizontal") * mainSpeed;
        trans.position += trans.TransformDirection(Vector3.down) * 1;

    }

    void InstBullet(Vector3 pos, Quaternion rotation){
        foreach(Transform t in bullets){
            if (!t.gameObject.activeSelf){
                t.SetPositionAndRotation(pos, rotation);
                t.gameObject.SetActive(true);
                return;
            }
        }
        Instantiate(bullet, pos, rotation, bullets);   
    }
    IEnumerator DelayTime(){
        yield return new WaitForSeconds(muzzleRoF);
    }
}
