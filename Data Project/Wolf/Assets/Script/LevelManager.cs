﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void Start(){
        SceneManager.LoadScene ("MainScene");
    }

    public void Quit(){
        Application.Quit();
    }
}
