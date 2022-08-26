using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingGun : MonoBehaviour
{ 
    public static int ShotCount => _shotCount;

   [SerializeField]
    GameObject _bulletPrefab;

   [SerializeField]
    float _shotSpeed;

   [SerializeField]
   static int _shotCount = 30;

   float _shotInterval;

    [SerializeField] public int shotBounce;
    private void Start()
    {
        boundConter.bounceLimit = shotBounce;
    }
    void Update(){
        if(GameManager.timeStop == false)
        {
            if (Input.GetKey(KeyCode.Mouse0)){
                _shotInterval += 1;
                if(_shotInterval % 5 == 0 && _shotCount > 0){
                    _shotCount -= 1;

                    GameObject bullet = (GameObject)Instantiate(_bulletPrefab, transform.position,Quaternion.Euler(transform.parent.eulerAngles.x,transform.parent.eulerAngles.y,0));
                    Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                    bulletRb.AddForce(transform.forward * _shotSpeed);

                    Destroy(bullet, 3.0f);
                } 
            }else if (Input.GetKeyDown(KeyCode.R)){
                _shotCount = 30;
            }
        }
    }
}
