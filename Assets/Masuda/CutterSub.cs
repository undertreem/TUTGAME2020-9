using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutterSub : MonoBehaviour
{
    public float timer = 0.0f;
    public GameObject CutterPrefab;
    private float downforce = -70.0f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer >= 2.5f)
        {
            rb.AddForce(0.0f, 0.0f, downforce);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            timer = 0.0f;
        }
    }
}
