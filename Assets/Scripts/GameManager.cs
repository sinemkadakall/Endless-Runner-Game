using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingletonMonoBehaviourObject<GameManager>
{
    public event System.Action OnGameStop;
    private void Awake()
    {
        SingletonThisObject(this);
    }

    public void StopGame()
    {
        Time.timeScale = 0f;
        OnGameStop?.Invoke();
    }

    public void LoadScene(string sceneName)
    {
        StartCoroutine(LoadSceneAsycn(sceneName));
    }

    private IEnumerator LoadSceneAsycn(string sceneName)
    {
        Time.timeScale = 1f;
        yield return SceneManager.LoadSceneAsync(sceneName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
