using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESCAPE : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
