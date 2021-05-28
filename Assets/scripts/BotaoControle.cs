using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoControle: MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite newImage;

    public KeyCode keytopress;

    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keytopress))
        {
            theSR.sprite = newImage;
        }

        if (Input.GetKeyUp(keytopress))
        {
            theSR.sprite = defaultImage;
        }
    }
}
