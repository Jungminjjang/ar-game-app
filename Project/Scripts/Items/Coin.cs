using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : Item
{
    public string coinName;
    public string description;
    public Sprite coinIMG;


    public Coin(string _id, string _name, string description)
    {
        ID = _id;
        coinName = _name;
        this.description = description;
    }
    
    public void AppearCoin()
    {
    }
    //TODO: migrate coin animation code HERE
}
