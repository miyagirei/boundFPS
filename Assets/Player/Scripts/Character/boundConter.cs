using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundConter : MonoBehaviour
{
    public int bounceCount;
    public static int bounceLimit;
    [SerializeField]public int[] damege;
    [SerializeField] public int[] money;
    [SerializeField]public static int weaponSelected;
    private void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Wall"|| col.gameObject.tag == "ground"){
            bounceCount++;
            if(bounceLimit <= bounceCount){
                Destroy(gameObject);
            }
        }
        if(col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<EnemyHP>().ReceveDamege(damege[weaponSelected]);

            Destroy(gameObject);
        }
        if(col.gameObject.tag == "Head")
        {
            print("Head");
            GameManager.GetScore(10);
            //col.gameObject.GetComponent<EnemyHP>().ReceveDamege(damege[0]);
        }
    }
}
