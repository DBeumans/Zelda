using UnityEngine;
using System.Collections;

public class Enemy_Movement : MonoBehaviour {

    [SerializeField]
    private float maxSpeed = 5;
    [SerializeField]
    private float mass = 20;
    [SerializeField]
    private bool followPath = false;
    
    private Vector2 currentVelocity;
    private Vector2 currentPosition;
    
    private Vector2 currentTarget;

    void Start()
    {
        currentVelocity = new Vector2(0, 0);
        currentPosition = transform.position;
    }
    
    void Update()
    {
        Seek();
    }

    public void setTarget(Vector2 target)
    {
        currentTarget = target;
    }
    
    public Vector2 Target
    {
        get
        {
            return currentTarget;
        }
    }

    void Seek()
    {
        Vector2 desiredStep = currentTarget - currentPosition;
        desiredStep.Normalize();
        
        Vector2 desiredVelocity = desiredStep * maxSpeed;
        
        Vector2 steeringForce = desiredVelocity - currentVelocity;
        
        currentVelocity += steeringForce / mass;
        
        currentPosition += currentVelocity * Time.deltaTime;
        transform.position = currentPosition;
        
        if (followPath)
        {
            float angle = Mathf.Atan2(currentVelocity.y, currentVelocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

}
