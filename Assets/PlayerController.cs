using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioClip shoutSE;   // Audio�p

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // �E���L�[�������ꂽ�Ƃ�
            transform.Translate(3, 0, 0);   // x������3������
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // �����L�[�������ꂽ�Ƃ�
            transform.Translate(-3, 0, 0);  // x������-3������
        }
        
    }

    // �������������Audio(ArrowController����Ăяo��)
    public void Shout()
    {
        AudioSource.PlayClipAtPoint(shoutSE, transform.position);
    }
}
