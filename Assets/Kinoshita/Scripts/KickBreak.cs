using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickBreak : MonoBehaviour
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
            child.gameObject.AddComponent<Rigidbody>();
            child.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            // 子要素リストにパーツを追加
            myParts.Add(child.gameObject);

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Explode();
        }
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
            Vector3 forcePower = new Vector3(Random.Range(0.0f, Power), Random.Range(-Power * 0.5f, Power * 0.5f), Random.Range(-Power * 0.5f, Power * 0.5f));
            Vector3 TorquePower = new Vector3(Random.Range(-Torque, Torque), Random.Range(-Torque, Torque), Random.Range(-Torque, Torque));

            obj.GetComponent<Rigidbody>().isKinematic = false;
            obj.GetComponent<Rigidbody>().AddForce(forcePower, ForceMode.Impulse);
            obj.GetComponent<Rigidbody>().AddTorque(TorquePower, ForceMode.Impulse);
            //5秒後に消す
            Destroy(gameObject, 5.0f);
        }
    }
}
