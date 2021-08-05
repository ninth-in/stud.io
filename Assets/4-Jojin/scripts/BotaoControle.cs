using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoControle: MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite newImage;
    bool active = false;
    GameObject nota;
    public bool createMode;
    public GameObject n;

    public KeyCode key;

    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (createMode)
        {
            if (Input.GetKeyDown(key))
                Instantiate(n, transform.position, Quaternion.identity);
        }

        else {

            if (Input.GetKeyDown(key) && active)
            {
                Debug.Log("hit");
                Destroy(nota);
            } else { Debug.Log("miss"); }

                    if (Input.GetKeyDown(key))
                    {
                        theSR.sprite = newImage;
                    }

                    if (Input.GetKeyUp(key))
                    {
                        theSR.sprite = defaultImage;
                    }
                }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "Nota")
            nota = collision.gameObject;

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        active = false;

    }

}
