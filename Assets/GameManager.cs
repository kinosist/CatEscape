using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject hpGauge;
    public GameObject txt;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        hpGauge = GameObject.Find("hpGauge");
        //txt = GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void DecreaseHP()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        if (hpGauge.GetComponent<Image>().fillAmount <= 0)
        {
            txt.GetComponent<TextMeshProUGUI>().text = "GAME OVER";
            Destroy(player);
        }
    }
}
