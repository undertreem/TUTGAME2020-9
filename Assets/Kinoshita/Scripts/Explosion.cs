using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ExplodeM();
            Instantiate(burst_spark, transform.position, Quaternion.identity);
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Player"))
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
            Vector3 forcePower = new Vector3(Random.Range(-Power, Power), Random.Range(-Power, Power), Random.Range(-Power, Power));
            Vector3 TorquePower = new Vector3(Random.Range(-Torque, Torque), Random.Range(-Torque, Torque), Random.Range(-Torque, Torque));

            obj.GetComponent<Rigidbody>().isKinematic = false;
            obj.GetComponent<Rigidbody>().AddForce(forcePower, ForceMode.Impulse);
            obj.GetComponent<Rigidbody>().AddTorque(TorquePower,ForceMode.Impulse);
        }
    }
}