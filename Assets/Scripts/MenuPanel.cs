using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
   
    public void StartButton()
    {
        Debug.Log("Ýçerdeyim");
        GameManager.Instance.LoadScene("Game");
    }
    public void ExitButton()
    {
        Debug.Log("Çýktým");
        GameManager.Instance.ExitGame();
    }








}
