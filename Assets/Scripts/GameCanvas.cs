using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvas : MonoBehaviour
{
    [SerializeField] GameOverPanel _gameOverPanel;


    void Awake()
    {
        _gameOverPanel.gameObject.SetActive(false); 
    }

     void OnEnable()
    {
        GameManager.Instance.OnGameStop += HandleOnGameStop;
    }

    void OnDisable()
    {
        GameManager.Instance.OnGameStop -= HandleOnGameStop;
    }


    void HandleOnGameStop()
    {
        _gameOverPanel.gameObject.SetActive(true);

    }
}
