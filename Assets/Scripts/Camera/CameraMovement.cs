using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraMovement : MonoBehaviour {

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
    [SerializeField]
    float _angleX, _angleY, _angleZ;
    [SerializeField]
    float _posX, _posY, _posZ;
    
    void Start()
    {
        StartCoroutine(CameraRotation());
        StartCoroutine(CameraPosition());
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
}
