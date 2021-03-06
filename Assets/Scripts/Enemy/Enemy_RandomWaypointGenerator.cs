﻿using UnityEngine;
using System.Collections;

public class Enemy_RandomWaypointGenerator : MonoBehaviour {

    Enemy_WaypointBehaviour _enemyWaypointBehaviour;

    [SerializeField]
    GameObject _cube; // The waypoints generate inside this cube.

    float _minimalX, _maximalX;
    float _minimalY, _maximalY;
    float _minimalZ, _maximalZ;

    void Start()
    {
        // X
        _minimalX = -5;
        _maximalX = 5;
        // Y 
        _minimalY = 0;
        _maximalY = 5;
        // Z
        _minimalZ = -5;
        _maximalZ = 5;

        _enemyWaypointBehaviour = GetComponent<Enemy_WaypointBehaviour>();
        StartCoroutine(GenerateWayPoint());
    }

    IEnumerator GenerateWayPoint()
    {
        while (true)
        {
            if (_enemyWaypointBehaviour.Distance < _enemyWaypointBehaviour.MinimalDistance)
            {
                float x;
                float y;
                float z;
                x = Random.Range(_minimalX, _maximalX);
                y = Random.Range(_minimalY, _maximalY);
                z = Random.Range(_minimalZ, _maximalZ);
                Vector3 _newWayPoint;
                _newWayPoint = new Vector3(x, y,z);
                _enemyWaypointBehaviour.AddWayPoint(_newWayPoint);
            }

            // is at way point.
            yield return null;
        }
    }
}
