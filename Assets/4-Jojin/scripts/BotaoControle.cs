using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BotaoControle: MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite newImage;
    bool active = false;
    GameObject nota;
    public bool createMode;
    public GameObject n;
    public int scorePerNote = 100;
    private TextMeshPro scoreUI;

    public KeyCode key;

    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
        scoreUI = GameObject.FindGameObjectWithTag("Score").GetComponent<TextMeshPro>();
        scoreUI.text = "aaaaaaaaaaa";
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
                Destroy(nota);
            }

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
        {
            nota = collision.gameObject;
            addScore(collision.transform.position.y);
        }


    }

    void OnTriggerExit2D(Collider2D collision)
    {
        active = false;

    }

    void addScore(float variavely)
    {
        float difY = Mathf.Abs(transform.localPosition.y - variavely);
        //scoreUI.GetComponent<Text>().text = "aeeeeeeeeee";

       if (difY <= 1)
        {
            print("perfeito");
        }
        else if (difY > 1 && difY <= 2)
            print("Boa");
        else print("errou");


    }

}
