using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class BuyFish : MonoBehaviour
{
    public static BuyFish instance;
    [Header("BuyMenu Manager")] 
    public GameObject BuyMenu;
    public int ItemID;
    public float Exp;
    public int Coin;
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Cost;
    public TextMeshProUGUI Buyed;
    public Image ImageFish;
    public Button Men;
    public Button Women;
    public int CountBuyed;
    public GameObject FishObject;
    public bool hasbuy = false;

    void Awake()
    {
        instance = this;
        CountBuyed = 0;
    }

    void Update()
    {
        if (CountBuyed % 2 == 0)
        {
            Men.interactable = false;
            Women.interactable = true;
        }
        else
        {
            Men.interactable = true;
            Women.interactable = false;
        }
        Buyed.text = CountBuyed.ToString();
    }

    public void BuyStart(int ItemID, string name, int cost, float exp, int coin)
    {
        BuyMenu.SetActive(true);
        CountBuyed = 0;
        this.ItemID = ItemID;
        Exp = exp;
        Coin = coin;
        ImageFish.sprite = Resources.Load<Sprite>($"Fish/{ItemID.ToString()}");
        Name.text = name;
        Cost.text = cost.ToString();
        Buyed.text = CountBuyed.ToString();
        hasbuy = true;
    }

    public void Buy()
    {
        Player.instance.Gold -= Int32.Parse(Cost.text);
        float randomX = Random.Range(-8.6f, 7.6f);
        float randomY = Random.Range(-2.5f, 1f) ;
        GameObject go = Instantiate(FishObject, transform.position, Quaternion.identity) as GameObject;
        go.transform.parent = GameObject.Find("Fishs").transform;
        go.transform.position = new Vector3(randomX, randomY, (float)90.00);
        var Fishimage = go.GetComponent<SpriteRenderer>();
        Fishimage.sprite = ImageFish.sprite;
        go.transform.localScale = new Vector3(10, 10, 1);
        Fish.intance.getInfomation(ItemID, Exp, Coin, (CountBuyed%2));
        CountBuyed++;
    }

    public void Cancel()
    {
        BuyMenu.SetActive(false);
        hasbuy = false;
    }
}
