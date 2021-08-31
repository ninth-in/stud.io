using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selcaoMusicas : MonoBehaviour
{
    public void AcessaMusica(string nome)
    {
        print("aqui " + nome);
        SceneManager.LoadScene(nome);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
