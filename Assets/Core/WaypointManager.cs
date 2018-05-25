using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour {

    public static WaypointManager instance;

    public List<WaypointController> waypoints;

    void Awake()
    {
        instance = this;
    }


    void Start () {


    }

    public WaypointController GetStart()
    {
        WaypointController next = waypoints[0];
        return next;
    }

    public WaypointController GetNext(int current)
    {
        int index = (current + 1);
        if (index >= waypoints.Count)
        {
            return null;
        }
        WaypointController next = waypoints[current + 1];
        return next;
    }


}
