using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    //これは敵に付けてください
    private GameObject player;
    private NavMeshAgent nav;
    private Vector3 targetPos;
    private float eneDis;//追加
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        nav = this.gameObject.GetComponent<NavMeshAgent>();
        eneDis = 7.0f;//追加
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = player.transform.position;
        //この下変更＆追加
        if (Vector3.Distance(targetPos, this.transform.position) <= eneDis)
        {
            nav.destination = targetPos;
        }
        else
        {
            nav.destination = this.transform.position;
        }
    }
}
