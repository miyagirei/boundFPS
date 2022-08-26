using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelLoder : MonoBehaviour
{
    [SerializeField] GameObject[] _excludePanel;
    public void PlayLoadPanel(GameObject loadPanel)
    {
        if (!loadPanel.activeSelf)
        {
            for(int i = 0; i < _excludePanel.Length; i++)
            {
                _excludePanel[i].SetActive(false);
            }
            loadPanel.SetActive(true);
        }
        else if (loadPanel.activeSelf)
        {
            loadPanel.SetActive(false);
        }
    }
}
