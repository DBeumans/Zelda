using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraMovement : MonoBehaviour
{ 
    Camera _camera;    
    [SerializeField]
    private GameObject[] playerPos;

    Vector3 _offset;

    [SerializeField]
    float _angleX, _angleY, _angleZ;
    
    [SerializeField]
    float _posX, _posY, _posZ;

    [SerializeField]
    bool _toggleTargetView = false;

    [SerializeField]
    float _lookDistance;
    
    void Start()
    {
        _camera = GetComponent<Camera>();

        _offset = new Vector3(_posX, _posY, _posZ);
    }

    void FixedUpdate()
    {
        if (_toggleTargetView)
        {
            if (playerPos[0] != null && playerPos[1] != null)
            {

                Vector3 lookPoint = Vector3.Lerp(playerPos[0].transform.position, playerPos[1].transform.position, 0.5f);

                float distance = Vector3.Distance(playerPos[0].transform.position, playerPos[1].transform.position);

                if (distance < _lookDistance)
                {
                    _camera.transform.LookAt(lookPoint);
                }
                else
                {
                    this.transform.localEulerAngles = new Vector3(_angleX, _angleY, _angleZ);
                }

            }
        }
        else
        {
            this.transform.position = _offset;
            transform.localEulerAngles = new Vector3(_angleX, _angleY, _angleZ);
        }

       
    }
}