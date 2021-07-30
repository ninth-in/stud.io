using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geranota : MonoBehaviour
{
    [SerializeField]
    private GameObject notaDireita;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnaSeta", 0.0f, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnaSeta()
    {
        Instantiate(notaDireita, transform.position, Quaternion.identity);
    }
}
