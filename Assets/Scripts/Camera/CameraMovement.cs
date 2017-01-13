using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraMovement : MonoBehaviour
{
    /*
    Camera _camera;

    [SerializeField]
    Transform _target;

    [SerializeField]
    bool _smooth;
    [SerializeField]
    float _smoothSpeed = .1f;
    Vector3 _offset;
    /*
        opslaan in array,list of dictionary.
    */
    /*
    [SerializeField]
    float _angleX, _angleY, _angleZ;
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
    }

    void FixedUpdate()
    {
        
        Vector3 _desiredPosition = _target.transform.position + _offset;
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
            transform.eulerAngles = new Vector3(_angleX,_angleY,_angleZ);
            yield return null;
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
    */

    private Camera cameraRef;
    [SerializeField]
    private GameObject[] playerPos;

    void Start()
    {
        cameraRef = GetComponent<Camera>();
        Debug.Log(playerPos[0].transform.position);
        Debug.Log(playerPos[1].transform.position);
        Debug.Log(cameraRef.tag);
        StartCoroutine(ZoomInOut());
    }

    IEnumerator ZoomInOut()
    {
        while (true)
        {
            if (playerPos[0] != null && playerPos[1] != null)
            {

                Vector3 lookPoint = Vector3.Lerp(playerPos[0].transform.position, playerPos[1].transform.position, 0.5f);
                cameraRef.transform.LookAt(lookPoint);


                yield return new WaitForSeconds(0.02f);
            }

        }
    }
}