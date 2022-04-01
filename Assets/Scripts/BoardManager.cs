using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public static BoardManager Instance;
    public Square SquarePrefab;
    public Line LinePrefab;

    private void Awake()
    {
        Instance = this;
    }
    // Texture2D.GetPixel

    public void GenerateBoard()
    {
        int Width = MainMenu.N-1;
        int Height = MainMenu.N-1;
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                var p = new Vector2(i, j);
                Instantiate(SquarePrefab, p, Quaternion.identity);

            }
        }
        var center = new Vector2((float)Height / 2 - 0.5f, (float)Width / 2 - 0.5f);
        Camera.main.transform.position = new Vector3(center.x, center.y, -5);
        Debug.Log(MainMenu.N);

    }
    public void SetPoint(Point p)
    {
        GameManager.Instance.SwitchPlayer();

    }
    public void SetLine(Line p)
    {
        GameManager.Instance.SwitchPlayer();

    }

}
