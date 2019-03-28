using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class OnGoingTimer : DigitalWatch
{
    public TimeSpan duration;

    public OnGoingTimer(int seconds) : base(Mode.Timer)
    {
        duration
            = new TimeSpan(seconds * TimeSpan.TicksPerSecond);
        data = data.Add(duration);
    }

    public override void Start()
    {
        base.Start();

        StartCoroutine( TimeUpdate() );
    }
}