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
        // �t���[�����Ƃɓ����ŗ���������
        transform.Translate(0, speed, 0);

        // ��ʊO�ɏo���I�u�W�F�N�g��j������
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // �����蔻��
        Vector2 p1 = transform.position;                // ��̒��S���W
        Vector2 p2 = this.player.transform.position;    // �v���C���[�̒��S���W
        Vector2 dir = p2 - p1;
        float d = dir.magnitude;
        float r1 = 0.5f;    // ��̔��a
        float r2 = 1f;      // �v���C���[�̔��a

        if (d < r1 + r2)
        {
            // �v���C���[�ɖ�󂪓��������I
            // �Q�[���}�l�[�W���[�Ƀv���C���[�Ɩ�󂪓����������Ƃ�`����
            GameObject manager = GameObject.Find("GameManager");
            manager.GetComponent<GameManager>().DecreaseHP();
            Destroy(gameObject);    // ��������
            this.player.GetComponent<PlayerController>().Shout();
        }
    
        
    }
}
