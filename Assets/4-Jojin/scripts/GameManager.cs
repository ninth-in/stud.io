using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource music;
    public static GameManager instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NoteHit()
    {
        Debug.Log("Hit on time");
    }

    public void NoteMissed()
    {
        Debug.Log("Missed");
    }
}
