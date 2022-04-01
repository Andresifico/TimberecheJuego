using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinFinal : MonoBehaviour
{
    public GameObject selectedskin;
    public GameObject selectedskin2;
    public GameObject Player1;
    public GameObject Player2;


    private Sprite playersprite;
    private Sprite playersprite2;
    public static Sprite Player1F;
    public static Sprite Player2F;


    // Start is called before the first frame update
    void Start()
    {
        playersprite = selectedskin.GetComponent < SpriteRenderer>().sprite ;

        Player1.GetComponent<SpriteRenderer>().sprite = playersprite;

        playersprite2 = selectedskin2.GetComponent<SpriteRenderer>().sprite;

        Player2.GetComponent<SpriteRenderer>().sprite = playersprite2;
    }

    // Update is called once per frame
    void Update()
    {
        playersprite = selectedskin.GetComponent<SpriteRenderer>().sprite;

        Player1.GetComponent<SpriteRenderer>().sprite = playersprite;

        playersprite2 = selectedskin2.GetComponent<SpriteRenderer>().sprite;

        Player2.GetComponent<SpriteRenderer>().sprite = playersprite2;
    }
}
