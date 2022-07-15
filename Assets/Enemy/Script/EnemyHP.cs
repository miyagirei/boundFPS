using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour{
    int _enemyHP = 100;

    public void ReceveDamege(int damegeScore){
        _enemyHP -= damegeScore;
        //Debug.Log("enemyHP :" + _enemyHP);
        if(_enemyHP <= 0){
            GameManager.GetScore(100);
            Destroy(this.gameObject);
        }
    }
}
