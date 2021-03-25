using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Vector3 cameraoffset = new Vector3(0, 5, -7);
    public GameObject player;
    
    void Update()
    {
        transform.position = player.transform.position + cameraoffset;
    }
}
