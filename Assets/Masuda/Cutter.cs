using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{
    public GameObject CutterPrefab;
    public AudioClip CutterSound;
    private float timer;
    private float timeBetweenShot = 4.0f;
    public float CutterBreakTime;
    public float power;

    void Update()
    {
        timer += Time.deltaTime;
            //if (timer > CutterBreakTime / 2.0f)
           // {
           // power = -power;
          //  }
        // もしもJキーを押したならば（条件）
        if (Input.GetKeyDown(KeyCode.J) && timer > timeBetweenShot)
        {
            timer = 0.0f;
            GameObject Cutter = Instantiate(CutterPrefab, transform.position, Quaternion.identity);
            Rigidbody CutterRb = Cutter.GetComponent<Rigidbody>();
            CutterRb.AddForce(0.0f, 0.0f, power);

            
            // 発射したカッターを破壊する。
            Destroy(Cutter, CutterBreakTime);

            //カッター射出時の音
            AudioSource.PlayClipAtPoint(CutterSound, transform.position);


        }


    }
}
