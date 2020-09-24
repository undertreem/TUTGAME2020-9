﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPScript : MonoBehaviour
{
    private static float HPPoint = 50.0f;
    private GameObject HPText0b;
    private Text HPText;
    // Start is called before the first frame update
    void Start()
    {
        HPText0b = GameObject.Find("HP");
        HPText = HPText0b.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        HPText.text = "HP : " + HPPoint;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            HPPoint--;
            other.gameObject.SetActive(false);
        }
    }
    public static float HPGetter()
    {
        return HPPoint;
    }
}