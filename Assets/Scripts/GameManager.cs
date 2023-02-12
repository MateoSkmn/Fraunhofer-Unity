using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int frameRate = 60;

    private void Awake()
    {
        //Schont GPU
        Application.targetFrameRate = frameRate;
    }
}
