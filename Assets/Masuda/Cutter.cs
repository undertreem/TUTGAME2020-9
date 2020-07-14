using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{
     public GameObject CutterPrefab;
    public float shotSpeed;
    public AudioClip CutterSound;
    private float timer;
    private float timeBetweenShot = 1.1f;

    void Update()
    {
        timer += Time.deltaTime;
        // もしもzキーを押したならば（条件）
        if (Input.GetKeyDown(KeyCode.Z) && timer > timeBetweenShot)
        {
            timer = 0.0f;

            GameObject Cutter  = Instantiate(CutterPrefab, transform.position, Quaternion.identity);

            Rigidbody CutterRb = Cutter.GetComponent<Rigidbody>();

            CutterRb.AddForce(transform.forward * shotSpeed);

            // 発射したカッターを1秒後に破壊する。
            Destroy(Cutter, 1.0f);

            //カッター射出時の音
            AudioSource.PlayClipAtPoint(CutterSound, transform.position);

        }
    }
}
