using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeModel : MonoBehaviour
{
    public GameObject playerModel1;
    public GameObject playerModel2;
    public GameObject playerModel3;
    private float esaP;
    // Start is called before the first frame update
    void Start()
    {
        playerModel1.SetActive(true);
        playerModel2.SetActive(false);
        playerModel3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        esaP = APScript.EsaPGetter(); 
        //取った時に変わる個数
        if(esaP == 2)
        {
            playerModel1.SetActive(false);
            playerModel2.SetActive(true);
            playerModel3.SetActive(false);
        }
        if(esaP == 4)
        {
            playerModel1.SetActive(false);
            playerModel2.SetActive(false);
            playerModel3.SetActive(true);
        }
    }
}
