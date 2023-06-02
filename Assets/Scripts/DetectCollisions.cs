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
        //スコア加算？
        player = GameObject.Find("Player");
        pc = player.GetComponent<PlayerController>();
        pc.SetCountText(point);;//Playerにスコア更新を依頼
        Destroy(gameObject);//アタッチされている自分自身を消す
        Destroy(other.gameObject);//ぶつかった相手（other）を消す
    }
}
