using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movetween : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(gameObject, 0.5f, 3).setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
