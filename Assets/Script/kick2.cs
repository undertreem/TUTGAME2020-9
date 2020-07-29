using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kick2 : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.G))
        {
            transform.Rotate(0f, 720.0f * Time.deltaTime, 0f);
        }

    }
}
