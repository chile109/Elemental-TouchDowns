using System.Threading;
using System;
using UnityEngine;

public class AnimalRunEvent : AAREventReceiver
{
    public GameObject Model;

    bool FlagClose = false;
    TimeSpan ts;
    DateTime startDate;
    double target_Time = 3;

    public override void OnMarkerFound(ARTrackable marker)
    {
        //Spawn 
        FlagClose = false;
        Thread thr = new Thread(Func_NoArguments);
        startDate = DateTime.Now;
        Debug.Log("StartSpawn");
        thr.Start();
    }

    public override void OnMarkerLost(ARTrackable marker)
    {
        //Stop Spawn
        Debug.Log("StopSpawn");
        FlagClose = true;
    }

    public override void OnMarkerTracked(ARTrackable marker)
    {

    }

    void Func_NoArguments()
    {
        Debug.Log("thread start");
        while (!FlagClose)
        {
            Thread.Sleep(10);
            ts = DateTime.Now - startDate;
            if (ts.TotalSeconds >= target_Time)
            {
                startDate = DateTime.Now;
                MainTask.Singleton.AddTask(delegate {
                    Model.SetActive(true);
                });
                Debug.Log("Run Func_NoArguments");
            }
        }
    }
}
