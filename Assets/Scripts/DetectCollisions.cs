using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    private GameObject player;
    private PlayerController pc;
    [SerializeField] int point;

    

    private void OnTriggerEnter(Collider other) 
    {
        //�X�R�A���Z�H
        player = GameObject.Find("Player");
        pc = player.GetComponent<PlayerController>();
        pc.SetCountText(point);;//Player�ɃX�R�A�X�V���˗�
        Destroy(gameObject);//�A�^�b�`����Ă��鎩�����g������
        Destroy(other.gameObject);//�Ԃ���������iother�j������
    }
}
