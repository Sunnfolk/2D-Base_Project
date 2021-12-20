using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DebugOnScreen : DebugGUI
{
    public float Score = 0f;
    public float Health = 100f;
    
    private float Velocity = 0f;

    private RectOffset rectOff;
    private void OnGUI()
    {
       // GUI.skin.box.wordWrap = true;
        rectOff = GUI.skin.box.overflow;

        RightTopBox(0f, 80, 25, $"Health: {Health}");
        RightTopText(25f, 80, 25, $"Score:{Score} ");
        
        RightBottomBox($"Velocity: {Velocity}" );
    }
}
