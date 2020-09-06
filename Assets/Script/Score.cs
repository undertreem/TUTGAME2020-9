using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int ScorePoint = 0;
    int VenderScore = 100;
    int HouseScore = 400;
    int SoukoScore = 600;
    int BuildingScore = 1000;
    int TreeScore = 200;

    public void GetVender()
    {
        ScorePoint += VenderScore;
    }
    public void GetHouse()
    {
        ScorePoint += HouseScore;
    }
    public void GetSouko()
    {
        ScorePoint += SoukoScore;
    }
    public void GetBuilding()
    {
        ScorePoint += BuildingScore;
    }
    public void GetTree()
    {
        ScorePoint += TreeScore;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "Score : " + ScorePoint;
    }
}