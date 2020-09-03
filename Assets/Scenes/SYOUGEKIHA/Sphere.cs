﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public GameObject prefab;
    private bool flag = true;
    private float pullTime = 0.0f;
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            pullTime += 1.0f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) && flag ==true && pullTime >= 60)
        {
            StartCoroutine(CreateWave());
            flag = false;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            pullTime = 0.0f;
        }
    }
    IEnumerator CreateWave()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
        flag = true;
        yield break;
    }
}
