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
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        nav = this.gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = player.transform.position;
        nav.destination = targetPos;
    }
}
