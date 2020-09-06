using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutterBreak : MonoBehaviour
{
    public GameObject BreakEffect;
    public float Torque;
    public float Power;
    // 自身の子要素を管理するリスト
    List<GameObject> myParts = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        // 自分の子要素をチェック
        foreach (Transform child in gameObject.transform)
        {
            myParts.Add(child.gameObject);
            child.gameObject.AddComponent<Rigidbody>();
            child.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            // 子要素リストにパーツを追加

        }
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            Explode();
            Instantiate(BreakEffect, transform.position, Quaternion.identity);
        }
    }



    void Explode()
    {

        // 各パーツをふっとばす
        foreach (GameObject obj in myParts)
        {
            obj.GetComponent<Rigidbody>().isKinematic = false;
            //5秒後に消す
            Destroy(gameObject, 5.0f);
        }
    }
}
