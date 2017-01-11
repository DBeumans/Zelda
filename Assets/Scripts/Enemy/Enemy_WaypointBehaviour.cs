using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy_WaypointBehaviour : MonoBehaviour {

    // todo: zorg ervoor dat dit component een lijst met waypoints/Vectors kan bevatten (instelbaar vanuit de editor)
    [SerializeField]
    List<Vector3> _wayPoints = new List<Vector3>();
    Enemy_Movement _enemy_movement;

    float _minimalDistance = 1f;

    float _distance;

    public float MinimalDistance { get { return _minimalDistance; } }
    public float Distance { get { return _distance; } }

    void Start()
    {
        // todo: als er al waypoints beschikbaar zijn: ga richting de eerste waypoint
        _enemy_movement = GetComponent<Enemy_Movement>();

        NextWayPoint();
    }

    void Update()
    {

        _distance = Vector3.Distance(_enemy_movement.Target, transform.position);

        if (_distance < _minimalDistance)
        {
            NextWayPoint();
        }
    }

    void NextWayPoint()
    {
        if (_wayPoints.Count == 0)
            return;

        Vector3 _nextWaypoint;
        _nextWaypoint = _wayPoints[0];
        _wayPoints.RemoveAt(0);
        _enemy_movement.setTarget(_nextWaypoint);

    }

    // zorg ervoor dat er een addWayPoint method is
    public void AddWayPoint(Vector3 _waypoint)
    {
        _wayPoints.Add(_waypoint);
    }
}
