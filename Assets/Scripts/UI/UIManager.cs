using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    internal NetworkManager networkManager;

    private void Awake()
    {
        networkManager = FindObjectOfType<NetworkManager>();
    }
}
