using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
   
    public void StartButton()
    {
        Debug.Log("��erdeyim");
        GameManager.Instance.LoadScene("Game");
    }
    public void ExitButton()
    {
        Debug.Log("��kt�m");
        GameManager.Instance.ExitGame();
    }








}
