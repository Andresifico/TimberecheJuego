using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Line : MonoBehaviour
{
   
    public GameObject Button;
    public GameObject ButtonValue;
    public GameObject State;
    public GameObject Inner;
    public GameObject c;
    public GameObject s;
    public GameObject N;
    public GameObject S;
    public GameObject W;
    public GameObject E;
    public GameObject Win;
    
    public int stateN = 0;
    public int stateS = 0;
    public int stateW = 0;
    public int stateE = 0;
    private Vector2 _position;
    public Vector2 Pos => _position;
    public void Init(Vector2 position)
    {
        this._position = position;
    }


    private void OnMouseDown()
    {
        var cont = 0;
        if (GameManager.Instance.GetGameState == GameManager.GameState.player1)
        {
            Button.GetComponent<SpriteRenderer>().color = Color.green;
            


        }  
        else
        {
            Inner.GetComponent<SpriteRenderer>().color = Color.red;
            c.GetComponent<SpriteRenderer>().color = Color.red;
            s.GetComponent<SpriteRenderer>().color = Color.red;
        }


        BoardManager.Instance.SetLine(this);
        
        if (N.GetComponent<SpriteRenderer>().color != Color.white)
        {
            cont++;
            stateN = 1;
        }
            
            
        if (S.GetComponent<SpriteRenderer>().color != Color.white)
        {
            cont++;
            stateS = 1;
        }
        if (W.GetComponent<SpriteRenderer>().color != Color.white)
        {
            cont++;
            stateW = 1;
        }
        if (E.GetComponent<SpriteRenderer>().color != Color.white)
        {
            cont++;
            stateE = 1;
        }

        Debug.Log(cont);
        if (cont==3)
        {
            if (GameManager.Instance.GetGameState == GameManager.GameState.player1)
                Win.GetComponent<SpriteRenderer>().color = Color.blue;
            else
                Win.GetComponent<SpriteRenderer>().color = Color.red;
        }


    }
}
