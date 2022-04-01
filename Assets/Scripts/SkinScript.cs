using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinScript : MonoBehaviour
{
    public GameObject selectedskin;
    public GameObject Player1;


    private Sprite playersprite;
    private Sprite playersprite2;

    // Start is called before the first frame update
    void Start()
    {
        playersprite = selectedskin.GetComponent<SpriteRenderer>().sprite;

        Player1.GetComponent<SpriteRenderer>().sprite = playersprite;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
