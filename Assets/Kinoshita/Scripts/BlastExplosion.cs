using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastExplosion : MonoBehaviour
{
    public GameObject burst_spark;
    public float Torque;
    public float Power;
    private List<GameObject> myParts = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.AddComponent<Rigidbody>();
            child.gameObject.GetComponent<Rigidbody>().isKinematic = true;

            myParts.Add(child.gameObject);

        }
    }

    // Update is called once per frame
    private void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ブラスト"))
        {
            ExplodeM();
            Instantiate(burst_spark, transform.position, Quaternion.identity);
        }
    }


    //吹き飛ばし
    void ExplodeM()
    {
        foreach (GameObject obj in myParts)
        {
            Vector3 forcePower = new Vector3(Random.Range(0.0f, Power), Random.Range(-Power, Power), Random.Range(-Power, Power));
            Vector3 TorquePower = new Vector3(Random.Range(-Torque, Torque), Random.Range(-Torque, Torque), Random.Range(-Torque, Torque));

            obj.GetComponent<Rigidbody>().isKinematic = false;
            obj.GetComponent<Rigidbody>().AddForce(forcePower, ForceMode.Impulse);
            obj.GetComponent<Rigidbody>().AddTorque(TorquePower,ForceMode.Impulse);
            //5秒後に消す
            Destroy(gameObject, 5.0f);
        }
    }
}