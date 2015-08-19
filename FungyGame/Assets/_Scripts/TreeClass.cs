﻿using UnityEngine;
using System.Collections;

public enum TreeState { Alive, Infected, Dead };
public enum TreeType { Sapling = 0, SmallTree = 1, BigTree = 2, DeadTree = 3, CutTree = 4 }; //DEADTREE must be last!

public class TreeClass : MonoBehaviour
{
    public float growTime = 10f;
    public float randomGrowTimeRange = 5f;

    public TreeState State;
    public TreeType Type;

	public float _nextEventTime = 0f;
    public bool _processStarted = false;
    public Hexagon occupiedHexagon {get; set;}


    void Awake()
    {
        _nextEventTime = Time.time + Random.Range(growTime, growTime + randomGrowTimeRange);
        _processStarted = true;
    }
}
