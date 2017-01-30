using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy_Shooting : MonoBehaviour {

    [SerializeField]
    GameObject _bullet;

    [SerializeField]
    List<GameObject> _bulletsInScene = new List<GameObject>();

    // dit zorgt ervoor dat de list leeg gemaakt kan worden.
    // wanneer de bullet destroyed is, moet deze variable een call krijgen en de list leeg maken.
    public List<GameObject> SetBulletsInSceneList { get { return _bulletsInScene; } set { _bulletsInScene = value; } }

    float _time = 10;
    float _maxTime = 10;    

    void Update()
    {
        _time-=.05f;
        if(_time <=0)
        {
            _maxTime = Random.Range(1, 10);
            _time = _maxTime;
            Shoot();
        }
    }
    
    public void Shoot()
    {
        if (_bulletsInScene.Count != 0)
            return;
        Vector3 _targetPos = this.gameObject.transform.position;
        GameObject go = Instantiate(_bullet) as GameObject;
        go.gameObject.name = "bullet";
        go.transform.position = new Vector3(_targetPos.x, _targetPos.y, _targetPos.z+.4f);
        _bulletsInScene.Add(go);

    }
    
}
