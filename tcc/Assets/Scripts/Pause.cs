using UnityEngine;
using UnityEngine.InputSystem;
public class Pause : MonoBehaviour
{
    public bool IsPaused = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (!IsPaused) 
            {
                Paused();
            }
            else
            {
                Resume();
            }
        }

    }
    void Resume()
    {
        Time.timeScale = 1;
        IsPaused = false;
    }
    void Paused()
    {
        Time.timeScale = 0;
        IsPaused = true;
    }
}
