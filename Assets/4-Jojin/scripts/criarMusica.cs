using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criarMusica : MonoBehaviour
{
    [SerializeField]
    private GameObject notaDireita;

    [SerializeField]
    private GameObject notaEsquerda;

    [SerializeField]
    private GameObject notaCima;

    [SerializeField]
    private GameObject notaBaixo;

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
