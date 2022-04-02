using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Line : MonoBehaviour
{

    public GameObject Button;
    public GameObject Inner;
    public GameObject c;
    public GameObject Skin1;
    public GameObject Skin2;
    public GameObject s;
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


    private void OnMouseDown()
    {
        var cont = 0;
        if (N.GetComponent<SpriteRenderer>().color != Color.white)
        {
            cont++;
        }
        if (S.GetComponent<SpriteRenderer>().color != Color.white)
        {
            cont++;
        }
        if (W.GetComponent<SpriteRenderer>().color != Color.white)
        {
            cont++;
        }
        if (E.GetComponent<SpriteRenderer>().color != Color.white)
        {
            cont++;
        }

        if (cont == 3)
        {
            Debug.Log(cont);
            if (GameManager.Instance.GetGameState == GameManager.GameState.player1)
                Win.GetComponent<SpriteRenderer>().color = Color.blue;
            else
                Win.GetComponent<SpriteRenderer>().color = Color.red;
            Debug.Log("Tiene otro movimiento");
            if (Inner.GetComponent<SpriteRenderer>().color == Color.white)
            {
                if (GameManager.Instance.GetGameState == GameManager.GameState.player1)
                {
                    Inner.GetComponent<SpriteRenderer>().color = Color.blue;
                    c.GetComponent<SpriteRenderer>().color = Color.blue;
                    s.GetComponent<SpriteRenderer>().color = Color.blue;

                }
                else
                {
                    Inner.GetComponent<SpriteRenderer>().color = Color.red;
                    c.GetComponent<SpriteRenderer>().color = Color.red;
                    s.GetComponent<SpriteRenderer>().color = Color.red;
                }
            }
        }
        else
        {
            
            if (Inner.GetComponent<SpriteRenderer>().color == Color.white)
            {
                if (GameManager.Instance.GetGameState == GameManager.GameState.player1)
                {
                    //Button.GetComponent<SpriteRenderer>().color = Color.blue;
                    Inner.GetComponent<SpriteRenderer>().color = Color.blue;
                    c.GetComponent<SpriteRenderer>().color = Color.blue;
                    s.GetComponent<SpriteRenderer>().color = Color.blue;
                   

                }
                else
                {
                    //Button.GetComponent<SpriteRenderer>().color = Color.red;
                    Inner.GetComponent<SpriteRenderer>().color = Color.red;
                    c.GetComponent<SpriteRenderer>().color = Color.red;
                    s.GetComponent<SpriteRenderer>().color = Color.red;
                    
                }
                BoardManager.Instance.SetLine(this);

                
            }
            else
            {
                Debug.Log("Jugada no Valida");
            }
        }


        //Debug.Log(cont);



    }

   
}
