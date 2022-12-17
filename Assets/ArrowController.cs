using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float speed = -0.1f;
    GameObject player;
   
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");        
    }

    // Update is called once per frame
    void Update()
    {
        // フレームごとに等速で落下させる
        transform.Translate(0, speed, 0);

        // 画面外に出たオブジェクトを破棄する
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // 当たり判定
        Vector2 p1 = transform.position;                // 矢の中心座標
        Vector2 p2 = this.player.transform.position;    // プレイヤーの中心座標
        Vector2 dir = p2 - p1;
        float d = dir.magnitude;
        float r1 = 0.5f;    // 矢の半径
        float r2 = 1f;      // プレイヤーの半径

        if (d < r1 + r2)
        {
            // プレイヤーに矢印が当たった！
            // ゲームマネージャーにプレイヤーと矢印が当たったことを伝える
            GameObject manager = GameObject.Find("GameManager");
            manager.GetComponent<GameManager>().DecreaseHP();
            Destroy(gameObject);    // 矢印を消す
            this.player.GetComponent<PlayerController>().Shout();
        }
    
        
    }
}
