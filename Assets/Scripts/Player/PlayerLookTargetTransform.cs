using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookTargetTransform : MonoBehaviour {

    void Update()
    {
        this.transform.localPosition = new Vector3(0f, 20f, 0f);
    }
}
