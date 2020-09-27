using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    GameObject pointText;
    double ScorePoint = 0;
    double buf = 1.0;
    double VenderScore = 100;
    double HouseScore = 400;
    double SoukoScore = 600;
    double BuildingScore = 1000;
    double TreeScore = 200;
    double HumanScore = 300;
    double TankScore = 2000;
    double GoldenChickenScore = 10000;
    double EsaScore = 10;

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
    public void GetHuman()
    {
        ScorePoint += HumanScore;
    }
    public void GetTank()
    {
        ScorePoint += TankScore;
    }
    public void GetGoldenChicken()
    {
        ScorePoint += GoldenChickenScore;
    }
    public void Getesa()
    {
        ScorePoint += EsaScore;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.pointText = GameObject.Find("Point");
    }

    // Update is called once per frame
    void Update()
    {
        this.pointText.GetComponent<Text>().text = "Score : " + ScorePoint;
    }
}