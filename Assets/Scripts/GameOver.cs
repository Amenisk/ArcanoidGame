using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject _canvas;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0.0f;
        _canvas.SetActive(true);
    }
}
