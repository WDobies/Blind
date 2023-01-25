using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float velocity = 0.0f;
    float pos = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos += 1.0f*velocity;
        transform.localPosition = new Vector3(pos,0,0);
    }
}
