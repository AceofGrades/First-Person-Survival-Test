﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorVisibility: MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
