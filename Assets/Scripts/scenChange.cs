﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenChange : MonoBehaviour
{
    // Start is called before the first frame update
    public void changeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
