using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    void Start()
    {
        Application.targetFrameRate = 60;
        Invoke("BrokeWave", 0.8f);
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        transform.localScale += new Vector3(0.4f, 0.4f, 0.4f);
        this.gameObject.transform.position = player.transform.position;
    }
    void BrokeWave()
    {
        Destroy(this.gameObject);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") == false)
        {
            Destroy(other.gameObject);
            //Destroy(this.gameObject);
        }
    }
}