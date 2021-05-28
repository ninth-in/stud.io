using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    public float beatTempo;
    public bool comecou;
    private Vector3 posicaoCaixaVermelha;
    //private Pontos;

    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
        posicaoCaixaVermelha = GameObject.FindGameObjectWithTag("caixadireita").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       //transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        transform.Translate(Vector3.down * beatTempo);
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            verificaColisao();
        }
        
    }

    private void verificaColisao()
    {
        float difY = Mathf.Abs (transform.localPosition.y - posicaoCaixaVermelha.y);

        if (difY <= 1)
        {
            print("perfeito");
        }
        else if (difY > 1 && difY <= 2)
            print("Boa");
        else print("errou");
    }
}
