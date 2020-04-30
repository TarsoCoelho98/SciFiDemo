using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InitializeEnviroment();    
    }

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnableCursor();
    }


    private void InitializeEnviroment()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void EnableCursor()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

}
