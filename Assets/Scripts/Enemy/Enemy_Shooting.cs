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
        // simple timer, wil be changed.
        _time-=.05f;
        if(_time <=0)
        {
            _time = _maxTime;
            Shoot();
        }
    }
    
    public void Shoot()
    {
        // mag alleen schieten als er geen kogels in het veld zijn.
        if (_bulletsInScene.Count != 0)
            return;
        
        GameObject go = Instantiate(_bullet) as GameObject;
        go.gameObject.name = "bullet";
        go.transform.position = this.gameObject.transform.position;
        _bulletsInScene.Add(go);
    }
    
}
