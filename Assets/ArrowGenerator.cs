using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;    // 前フレームと現在フレームの時間差
        if (delta > span)
        {
            delta= 0;
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
        
    }
}
