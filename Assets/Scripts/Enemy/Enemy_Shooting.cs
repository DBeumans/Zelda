using UnityEngine;
using System.Collections;

public class Enemy_Shooting : MonoBehaviour {

    [SerializeField]
    GameObject _bullet;

    float _time = 10;
    float _maxTime = 10;

    /*
        Wat moet ik schieten ?
        Wanneer mag ik schieten ? {
            ik mag alleen schieten als er geen kogels in het veld zijn.
        }
        
    */
    

    void Update()
    {
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
        
        GameObject go = Instantiate(_bullet);
        go.transform.position = this.gameObject.transform.position;
        Debug.Log("Enemy Shoot");
    }
    
}
