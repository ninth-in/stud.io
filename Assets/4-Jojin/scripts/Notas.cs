using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notas : MonoBehaviour
{
    public bool apertado;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(tag == "GameController")
        {
            apertado = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (tag == "GameController")
        {
            apertado = false;
        }
    }

}
