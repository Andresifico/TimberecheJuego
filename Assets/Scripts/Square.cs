using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public GameObject N;
    public GameObject S;
    public GameObject W;
    public GameObject E;
    public GameObject Win;

    private Vector2 _position;
    public Vector2 Pos => _position;
    public void Init(Vector2 position)
    {
        this._position = position;
    }
    public void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (N.GetComponent<SpriteRenderer>().color == Color.blue)
            Debug.Log("north");
        if (N.GetComponent<SpriteRenderer>().color == Color.blue && S.GetComponent<SpriteRenderer>().color == Color.blue && E.GetComponent<SpriteRenderer>().color == Color.blue && W.GetComponent<SpriteRenderer>().color == Color.blue)
            Win.GetComponent<SpriteRenderer>().color = Color.blue;
    }


    }
