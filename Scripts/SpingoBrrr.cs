using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpingoBrrr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0 * Time.deltaTime, 25, Space.Self);
    }
}
