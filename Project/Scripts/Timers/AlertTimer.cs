using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertTimer : OnGoingTimer, IFadeable
{

    public AlertTimer(int seconds) : base(seconds)
    {

    }

    //toggle on -> Fade In / off -> Fade Out
    public IEnumerator Fade(bool toggle, float seconds)
    {
        float fadeTime = seconds;
        for (float i = 0; i < fadeTime; i += Time.deltaTime)
        {
            float alpha = toggle ? 
                i / fadeTime : 1 - i / fadeTime;
            TMPUGUI.color = new Color(1f, 1f, 1f, alpha);
            yield return null;
        }
    }
}
