using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public GameObject prefab;
    private bool flag = true;
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && flag == true)
        {
            StartCoroutine(CreateWave());
            flag = false;
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
