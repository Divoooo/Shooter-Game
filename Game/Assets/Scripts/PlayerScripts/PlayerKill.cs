﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKill : MonoBehaviour, IKillable
{
    public bool IsDead { get; private set; }

    public void Kill()
    {
        IsDead = true;
        SceneManager.LoadScene("GameOver");
    }
}
