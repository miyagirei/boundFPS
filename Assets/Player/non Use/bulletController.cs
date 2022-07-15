using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour{
    private int bulletBounce;
    public int bounceLimit;
    void Update(){
        transform.position += transform.forward * 10 * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision){
            Debug.Log("Collision");
        bulletBounce++;
            //gameObject.SetActive(false);      
    }
    private void OnBecameInvisible(){
        gameObject.SetActive(false);
    }
}
