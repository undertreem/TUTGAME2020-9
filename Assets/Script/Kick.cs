using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Kick : MonoBehaviour
{
    public float wSpeed = 360;
    public float adRotate = 100;

    float maxRotate = 360;
    float tmpRotate = 0;
    float startRotation;
    // Start is called before the first frame update
    void Start()
    {
        startRotation = this.transform.rotation.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.G))
        {
            this.transform.Rotate(new Vector3(adRotate, 0, 0) * 10);
            tmpRotate += (adRotate * Time.deltaTime);
            if (tmpRotate >= maxRotate)
            {
                this.transform.rotation = Quaternion.Euler(startRotation, 0, 0);
                tmpRotate = 360;
            }
        }
    }
}
