using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject offlineMenu;
    [SerializeField] private GameObject onlineMenu;
    private UIManager _uiManager;

    private void Awake()
    {
        _uiManager = GetComponent<UIManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartServer()
    {
        _uiManager.networkManager.StartServer();
        Debug.Log("Server started...");
        offlineMenu.SetActive(false);
        onlineMenu.SetActive(true);
    }

    public void CloseServer()
    {
        _uiManager.networkManager.StopServer();
        Debug.Log("Server stopped...");
        onlineMenu.SetActive(false);
        offlineMenu.SetActive(true);
    }
}
