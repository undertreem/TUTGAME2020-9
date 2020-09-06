using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenKick : MonoBehaviour
{
    public AudioClip KickSound;

    void Update()
    {
        Vector3 p = new Vector3(0, 0, 1);
        Vector3 q = new Vector3(0, 0, -1);
        // もしもKキーを押したならば（条件）
        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.Translate(p);

            //音
            AudioSource.PlayClipAtPoint(KickSound, transform.position);

        }
        if(Input.GetKeyUp(KeyCode.K))
        {
            transform.Translate(q);
        }


    }
}
