using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public Transform Background1;
    public Transform Background2;
    private bool center1 = false;
    private bool center2 = false;

    public Transform cam;
    public float depth;
    public float speed;



    // Update is called once per frame
    void Update()
    {
        if (cam.position.x == Background1.position.x) center1 = true;
        if (cam.position.x == Background2.position.x) center2 = true;

        if (center1)
        {
            Background2.position = new Vector3(Background1.position.x + 600f, transform.position.y,depth);
            center1 = !center1;
        }
        if (center2)
        {
            Background1.position = new Vector3(Background2.position.x + 600f, transform.position.y, depth);
            center2 = !center2;
        }

        Background1.transform.Translate(-speed, 0f, 0f);
        Background2.transform.Translate(-speed, 0f, 0f);
    }
}
