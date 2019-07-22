using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeControll : MonoBehaviour
{
  private bool isPaused;
    public GameObject pause;

  private void Pause(){
    if(Input.GetKeyDown("p") && !isPaused){
        Debug.Log("pause");
            pause.SetActive(true);
        Time.timeScale = 0.0000001f;
        isPaused = true;
    }
    else if(Input.GetKeyDown("p") && isPaused){
        Debug.Log("Un Paused");
            pause.SetActive(false);
            Time.timeScale = 1.1f;
        isPaused = false;
    }
}
    // Start is called before the first frame update
    void Start()
    {
        isPaused=false;
    }

    // Update is called once per frame
    void Update()
    {
        Pause();
    }
}
