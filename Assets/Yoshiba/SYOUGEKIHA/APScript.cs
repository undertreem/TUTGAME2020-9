using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class APScript : MonoBehaviour
{
    private float esaPoint = 0.0f;
    private GameObject esaText0b;
    private Text esaText;

    // Start is called before the first frame update
    void Start()
    {
        esaText0b = GameObject.Find("AP");
        esaText = esaText0b.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        esaText.text = "AP : " + esaPoint;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Esa"))
        {
            esaPoint++;
            other.gameObject.SetActive(false);
        }
    }
}
