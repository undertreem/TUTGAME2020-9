using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Transition : MonoBehaviour
{
    Animator animator;
    private float Speed;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            Speed++;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Speed++;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Speed++;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Speed++;
        }
        else
        {
            Speed = 0.0f;
        }

            animator.SetFloat("Move", Speed);
    }
}
