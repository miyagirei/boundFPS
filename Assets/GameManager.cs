using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    [SerializeField] public static bool timeStop = false;

    [SerializeField] public static int _score;
    public Text scoreText;

    [SerializeField] public static int _money;
    
    private IEnumerator Inoperable(float i){
        GameObject inputObj = GameObject.Find("MainCamera");
        SightDisplay sightDisplay = inputObj.GetComponent<SightDisplay>();
        sightDisplay.enabled = false;
        yield return new WaitForSeconds(i);
        sightDisplay.enabled = true;
        yield break;
    }

    public void CallInoperable(float i){
        StartCoroutine("Inoperable", i);
    }

    private void Update()
    {
        scoreText.text = _score.ToString();
        if (timeStop == false)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0 ;
        }
    }

    public static void GetScore(int score)
    {
        _score += score;
        _money += score;
    }


}
