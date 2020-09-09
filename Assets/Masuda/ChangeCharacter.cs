using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour
{
    GameObject FirstChicken;
    GameObject SecondChicken;
    public int FirstEvo = 100;
    public int ScorePoint;

    // Start is called before the first frame update
    void Start()
    {
        this.FirstChicken = GameObject.Find("1stChicken");
        this.SecondChicken = GameObject.Find("2ndChicken");
    }

    void Change()
    {
        FirstChicken.SetActive(true);
        SecondChicken.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ScorePoint >= FirstEvo)
        {
            FirstChicken.SetActive(false);
            SecondChicken.SetActive(true);
        }
    }
}