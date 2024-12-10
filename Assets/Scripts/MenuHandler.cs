using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public GameObject pausemenu;
    bool ispaused;
    public bool hideCursor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausemenu != null)
            {
                if (!ispaused)
                {
                    pausemenu.SetActive(true);
                    ispaused = true;
                    if (hideCursor)
                    {
                        Cursor.lockState = CursorLockMode.None;
                        //Cursor.visible = true;
                    }
                }
                else
                {
                    pausemenu.SetActive(false);
                    ispaused = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    //Cursor.visible = false;
                }
            }
            

        }

    }

    public void HidePauseMenu()
    {
        pausemenu.SetActive(false);
        ispaused = false;
    }

    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void EndGame()
    {
        Application.Quit();
    }

}
