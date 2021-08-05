using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPM : MonoBehaviour
{
    public float bpmJogo;

    // Start is called before the first frame update
    void Start()
    {
        bpmJogo = bpmJogo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
       transform.position -= new Vector3(0f, bpmJogo * Time.deltaTime, 0f);
        
    }

}
