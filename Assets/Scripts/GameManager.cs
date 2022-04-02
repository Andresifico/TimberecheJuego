using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private GameState _gameState;
    public GameObject Skin1;
    public GameObject Skin2;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        _gameState = GameState.start;
    }
    public void UpdateGameState(GameState gameState)
    {
        _gameState = gameState;
    }
    public GameState GetGameState => _gameState;
    public void SwitchPlayer()
    {
        if (_gameState == GameState.player1)
        {
            _gameState = GameState.player2;
            Skin1.SetActive(!Skin1.activeSelf);
            Skin2.SetActive(!Skin2.activeSelf);
        }
        else
        {
            _gameState = GameState.player1;
            Skin1.SetActive(!Skin1.activeSelf);
            Skin2.SetActive(!Skin2.activeSelf);
            
        }

    }
    //Hola Mundo

    // Update is called once per frame
    void Update()
    {
        switch(_gameState)
        {
            case GameState.start:
                UpdateGameState(GameState.player1);
                break;
            case GameState.player1:
                break;
            case GameState.player2:
                break;
            case GameState.end:
                break;
        }

    }
    public enum GameState
    {
        start,
        player1,
        player2,
        end
    }
}