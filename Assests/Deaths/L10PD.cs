﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L10PD : MonoBehaviour
{
    public void Redirect()
    {
        SceneManager.LoadScene("Level10Death");
    }
}
