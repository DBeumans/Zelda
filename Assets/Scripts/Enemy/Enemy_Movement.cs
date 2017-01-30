using UnityEngine;
using System.Collections;

public class Enemy_Movement : MonoBehaviour {

    [SerializeField]
    private float maxSpeed = 5;
    [SerializeField]
    private float mass = 20;
    [SerializeField]
    private bool followPath = false;

    public float GetMaxSpeed { get { return maxSpeed; } set { maxSpeed = value; } }
    
    private Vector3 currentVelocity;
    private Vector3 currentPosition;
    
    private Vector3 currentTarget;

    void Start()
    {
        currentVelocity = new Vector3(0, 0,0);
        currentPosition = transform.position;
    }
    
    void Update()
    {
        Seek();
    }

    public void setTarget(Vector3 target)
    {
        currentTarget = target;
    }
    
    public Vector3 Target
    {
        get
        {
            return currentTarget;
        }
    }

    void Seek()
    {
        Vector3 desiredStep = currentTarget - currentPosition;
        desiredStep.Normalize();
        
        Vector3 desiredVelocity = desiredStep * maxSpeed;
        
        Vector3 steeringForce = desiredVelocity - currentVelocity;
        
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
