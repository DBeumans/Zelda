using UnityEngine;
using System.Collections;

public class Enemy_RandomWaypointGenerator : MonoBehaviour {

    Enemy_WaypointBehaviour _enemyWaypointBehaviour;
    float _minimalX, _maximalX;
    float _minimalY, _maximalY;
    float _minimalZ, _maximalZ;

    float _time = 1f;
    void Start()
    {
        _minimalX = -20; _maximalX = 20;
        _minimalY = -20; _maximalY = 20;
        _minimalZ = -20; _maximalZ = 20;
        
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
