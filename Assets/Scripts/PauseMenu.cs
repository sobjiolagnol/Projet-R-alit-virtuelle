using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private Canvas menuCanvas;
    private bool isMenuOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        menuCanvas = GetComponent<Canvas>();
        menuCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isMenuOpen){
                menuCanvas.enabled = false;
                Time.timeScale = 1.0f;
                isMenuOpen = false;
            }
            else{
                menuCanvas.enabled = true;
                Time.timeScale = 0f;
                isMenuOpen = true;
            }
        }
    }

    public void QuitApp(){
        Application.Quit();
    }

    public void CloseMenu(){
        menuCanvas.enabled = false;
        Time.timeScale = 1.0f;
        isMenuOpen = false;
    }
}
