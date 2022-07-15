using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sightDisplay : MonoBehaviour{
    [SerializeField] Image sight;
    float _rayLength = 20000;
    RaycastHit hit;
    int _damegeScore = 1;


    GameObject gameManagerObj;
    GameManager gameManager;

    private void Start(){
        gameManagerObj = GameObject.Find("GameManager");
        gameManager = gameManagerObj.GetComponent<GameManager>();
    }
    void Update(){
        Ray ray = new Ray(transform.position + transform.rotation * new Vector3(0, 0, 0.01f), transform.forward);
        Debug.DrawRay(transform.position + transform.rotation * new Vector3(0, 0, 0.01f), transform.forward * _rayLength, Color.yellow);

        if(Physics.Raycast(ray,out hit, _rayLength)){
            string hitTagName = hit.transform.gameObject.tag;
            if(hitTagName == "Enemy"){
                sight.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
                if (Input.GetMouseButton(0)){
                    //hit.collider.GetComponent<EnemyHP>().ReceveDamege(_damegeScore);
                    gameManager.CallInoperable(0.2f);
                }
            } else {
                sight.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
            }
        } else {
            sight.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        }

    }
}
