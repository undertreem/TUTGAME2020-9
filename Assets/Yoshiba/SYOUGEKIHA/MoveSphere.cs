using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        Invoke("BrokeWave", 0.8f);
    }
    void Update()
    {
        transform.localScale += new Vector3(0.4f, 0.4f, 0.4f);

    }
    void BrokeWave()
    {
        Destroy(this.gameObject);
    }
    /*
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") == false)
        {
            Destroy(other.gameObject);
            //Destroy(this.gameObject);
        }
    }
    */
}