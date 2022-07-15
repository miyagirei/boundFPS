using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundWall : MonoBehaviour{
    public float bounce = 10.0f;

    private void OnCollisionEnter(Collision col){
        if (col.gameObject.tag == "Shell"){
                Vector3 norm = col.contacts[0].normal;
                Vector3 vel = col.rigidbody.velocity.normalized;
                vel += new Vector3(-norm.x * 2, 0f, -norm.z * 2);
                col.rigidbody.AddForce(vel * bounce, ForceMode.Impulse);
        }
        
    }
}
