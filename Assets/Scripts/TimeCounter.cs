using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeCounter : MonoBehaviour
{
    TMP_Text _Text;
    float _currentTime;

    private void Awake()
    {
        _Text = GetComponent<TMP_Text>();
    }
    private void Update()
    {
        _currentTime += Time.time;
        _Text.text=_currentTime.ToString(format:"0");
    }





}
