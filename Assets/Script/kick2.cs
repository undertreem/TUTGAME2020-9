using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kick2 : MonoBehaviour
{
    ///[SerializeField] GameObject Cube;
    bool rotStart = false;
    float speed = 1.0f;
    float rotAngle = 360f;
    float variation; //1秒間の変化
    float rot;

    // Start is called before the first frame update
    void Start()
    {
        variation = rotAngle / speed;
    }

    // Update is called once per frame
    void Update()
    {

        /***if (Input.GetKey(KeyCode.G))
        {
            transform.Rotate(0f, 720.0f * Time.deltaTime, 0f);
        }
        ***/

            if (rotStart)
            {
                transform.Rotate(0, variation * Time.deltaTime, 0);
                rot += variation * Time.deltaTime;
                if (rot >= rotAngle)
                {
                    rotStart = false;
                    transform.localRotation = Quaternion.Euler(0, 180, 0);
                }

            }

        if (Input.GetKey(KeyCode.G))
        {
            rot = 0f;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            rotStart = true;
        }

    }
}
