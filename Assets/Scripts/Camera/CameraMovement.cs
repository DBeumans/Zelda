using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraMovement : MonoBehaviour
{
    
    Camera _camera;
    [SerializeField]
    bool _smooth;
    [SerializeField]
    float _smoothSpeed = .1f;
    
    [SerializeField]
    private GameObject[] playerPos;

    Vector3 _offset;

    [SerializeField]
    float _angleX, _angleY, _angleZ;
    [SerializeField] float _default_angleY;
    
    [SerializeField]
    float _posX, _posY, _posZ;

    [SerializeField]
    float _fov; // camera field of view.
    
    void Start()
    {
        _camera = GetComponent<Camera>();
        StartCoroutine(CameraRotation());
        StartCoroutine(CameraPosition());
        StartCoroutine(CameraFieldOfView());
        StartCoroutine(ZoomInOut());
    }

    void FixedUpdate()
    {
     
        Vector3 _desiredPosition = playerPos[0].transform.position + _offset;
        if(_smooth)
        {
            transform.position = Vector3.Lerp(transform.position, _desiredPosition, _smoothSpeed);
        }
        else
        {
            transform.position = _desiredPosition;
        }
        
    }

    IEnumerator CameraRotation()
    {
        while(true)
        {
            //transform.eulerAngles = new Vector3(_angleX,_angleY,_angleZ);
            yield return new WaitForSeconds(.5f);
        }
    }

    IEnumerator CameraPosition()
    {
        while(true)
        {
            _offset = new Vector3(_posX,_posY,_posZ);
            yield return null;
        }
    }

    IEnumerator CameraFieldOfView()
    {
        while (true)
        {
            _camera.fieldOfView = _fov;
            yield return null;
        }
    }


    IEnumerator ZoomInOut()
    {
        while (true)
        {
            if (playerPos[0] != null && playerPos[1] != null)
            {

                Vector3 lookPoint = Vector3.Lerp(playerPos[0].transform.position, playerPos[1].transform.position, 0.5f);

                Vector3 _desiredPosition = transform.position + _offset;

                float distance = Vector3.Distance(playerPos[0].transform.position, playerPos[1].transform.position);

                if(distance < 10)
                {
                    _camera.transform.LookAt(lookPoint);
                }
                else
                {
                    _camera.transform.LookAt((playerPos[0].transform.position));
                }
                yield return new WaitForSeconds(0.02f);
            }

        }
    }
}