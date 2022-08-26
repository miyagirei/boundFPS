using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] public Text bulletCountText;
    [SerializeField] public GameObject playerPanel;
    [SerializeField] public GameObject settingPanel;
    [SerializeField] public GameObject buyPanel;

    public Text weaponSelectedText;

    public GameObject shell;
    void Start()
    {
        playerPanel.SetActive(false);
        settingPanel.SetActive(false);
        buyPanel.SetActive(false);
        shell.GetComponent<boundConter>();
        weaponSelectedText.text = boundConter.weaponSelected.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        bulletCountText.text = ("弾数 : " + ShootingGun.ShotCount);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(playerPanel.activeSelf == false)
            {
                playerPanel.SetActive(true);
                GameManager.timeStop = true;
                settingPanel.SetActive(false);
                buyPanel.SetActive(false);
            }else{
                playerPanel.SetActive(false);
                GameManager.timeStop = false;
                settingPanel.SetActive(false);
                buyPanel.SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            if(playerPanel.activeSelf == false && settingPanel.activeSelf == false)
            {
                if(buyPanel.activeSelf == false)
                {
                    buyPanel.SetActive(true);
                    GameManager.timeStop = true;
                }else
                {
                    buyPanel.SetActive(false);
                    GameManager.timeStop = false;
                }
            }
        }
    }

    public void Restart()
    {
        Scene loadScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadScene.name);
        GameManager.timeStop = false;
    }
    public void Continue()
    {
        playerPanel.SetActive(false);
        GameManager.timeStop = false;
    }
    public void Setting()
    {
        settingPanel.SetActive(true);
        playerPanel.SetActive(false);
    }
    public void Buy(int i)
    {
        if(GameManager._score >= shell.GetComponent<boundConter>().money[i])
         {
             Debug.Log(shell.GetComponent<boundConter>().damege[i]);
             boundConter.weaponSelected = i;
            weaponSelectedText.text = boundConter.weaponSelected.ToString();
             GameManager.GetScore(-shell.GetComponent<boundConter>().money[i]);
             Debug.Log("Buy" + 1);
         }
        print("Challenge");
    }
}
