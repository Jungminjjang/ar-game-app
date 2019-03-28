using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using TMPro;

public class DigitalWatch : MonoBehaviour
{
    public enum Mode { StopWatch, Timer, Clock }
    public readonly Mode watchType;

    private readonly bool isIncrementing;
    public DateTime data;
    
    public TextMeshProUGUI TMPUGUI;

    public virtual void Start()
    {
        TMPUGUI = GetComponent<TextMeshProUGUI>();
    }

    public DigitalWatch(Mode mode)
    {
        watchType = mode;
        switch (mode) {
            case Mode.StopWatch:
                data = DateTime.MinValue;
                isIncrementing = true;
                break;

            case Mode.Timer:
                data = DateTime.MinValue;
                isIncrementing = false;
                break;
                
            case Mode.Clock:
                data = DateTime.Now;
                isIncrementing = true;
                break;

            default:
                break;
        }
    }

    protected IEnumerator TimeUpdate()
    {
        while (true) {
            //TMPUGUI.SetText(
            //    string.Format("{0:D2}:{1:D2}:{2:D2}", data.Hour, data.Minute, data.Second));
            try {
                data = data.AddSeconds( isIncrementing ? 1.0f : -1.0f );
            }
            catch (ArgumentOutOfRangeException) {
                Debug.Log("타이머 종료\n");
                TMPUGUI.SetText("Timeout!");
                StopCoroutine(TimeUpdate());
            }

            yield return new WaitForSecondsRealtime(1.0f);
        }

    }
}
