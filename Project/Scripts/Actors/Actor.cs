using System;
using System.Collections;
using UnityEngine;

public class Actor : MonoBehaviour
{
    public ActorType type;
    public string ID { get; private set; }
    public string name;

    void Start () {
		
	}
	
	void Update () {
		
	}
}

public enum ActorType {
    Unknown, Player, Friend, Neutral, Enemy
}
public enum ActorRelation {
    Unknown, Friendly, Neutral, Alerted, Hostile
}