using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMove : MonoBehaviour
{
    private Vector3 moveVec;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        speed = 6.0f;
    }

    // Update is called once per frame
    void Update()
    {
        moveVec = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        this.transform.Translate(moveVec * speed * Time.deltaTime);
    }
}