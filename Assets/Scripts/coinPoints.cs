﻿using UnityEngine;
using UnityEngine.UI;

public class coinPoints : MonoBehaviour
{
    public GUIStyle style;
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 11, Screen.height / 5, 100, 20), points + " / 1", style);
        style.fontSize = 25;
        style.normal.textColor = Color.white;
    }
}