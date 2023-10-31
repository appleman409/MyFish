using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    [Header("Player Infomation")] 
    public int connid;
    public int Uin;
    public string Username;
    public float Exp;
    public float MaxExp;
    public int Gold;
    public int Level;
    [Header("Aquarium Infomation")] 
    public List<Aquarium> Aquariums = new List<Aquarium>();
    public int SlotAqua;

    private void Awake()
    {
        instance = this;
    }
    
    public class Fish
    {
        public int FishId;
        public int Level;
        public float Food;
        public float Grow;
    }

    public class Aquarium
    {
        public int ID;
        public int Slot;
        public int MaxFish;
        public int CurFish;
        public Fish[] fishs = new Fish[] {};
}
}
