using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kuzureru : MonoBehaviour
{
    // 自身の子要素を管理するリスト
    List<GameObject> myParts = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        // 自分の子要素をチェック
        foreach (Transform child in gameObject.transform)
        {


            // 子要素リストにパーツを追加
            myParts.Add(child.gameObject);

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            ExplodeM();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ExplodeM();
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            ExplodeM();
        }
    }



    void ExplodeM()
    {

        // 各パーツをふっとばす
        foreach (GameObject obj in myParts)
        {
            obj.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
