using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingGun : MonoBehaviour
{
   [SerializeField] public GameObject bulletPrefab;
   [SerializeField] public float shotSpeed;
   [SerializeField] public static int shotCount = 30;
    private float shotInterval;

    [SerializeField] public int shotBounce;
    private void Start()
    {
        boundConter.bounceLimit = shotBounce;
    }
    void Update(){
        if(GameManager.timeStop == false)
        {
            if (Input.GetKey(KeyCode.Mouse0)){
                shotInterval += 1;
                if(shotInterval % 5 == 0 && shotCount > 0){
                    shotCount -= 1;

                    GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position,Quaternion.Euler(transform.parent.eulerAngles.x,transform.parent.eulerAngles.y,0));
                    Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                    bulletRb.AddForce(transform.forward * shotSpeed);

                    Destroy(bullet, 3.0f);
                } 
            }else if (Input.GetKeyDown(KeyCode.R)){
                shotCount = 30;
            }
        }
    }
}
