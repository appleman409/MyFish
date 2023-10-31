using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public static Fish intance;
    
    [Header("Fish Infomation")] 
    public int ItemId;
    public float getExp;
    public int getCoin;
    public float Level;
    public int Gender;
    public int Mature;
    public int TimeFood;

    private void Awake()
    {
        intance = this;
    }

    public void getInfomation(int ID, float Exp, int Coin, int g)
    {
        ItemId = ID;
        getExp = Exp;
        getCoin = Coin;
        Gender = g;
        TimeFood = 0;
        Mature = 0;
    }
}
