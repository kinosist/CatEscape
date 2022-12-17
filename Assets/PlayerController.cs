using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioClip shoutSE;   // Audio用

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // 右矢印キーが押されたとき
            transform.Translate(3, 0, 0);   // x方向に3動かす
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // 左矢印キーが押されたとき
            transform.Translate(-3, 0, 0);  // x方向に-3動かす
        }
        
    }

    // 矢が当たった時のAudio(ArrowControllerから呼び出し)
    public void Shout()
    {
        AudioSource.PlayClipAtPoint(shoutSE, transform.position);
    }
}
