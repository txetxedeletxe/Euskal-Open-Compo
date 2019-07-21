using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BlockScene;
    public float speedSum;
    public float totalSpeed;
    void Start(){
        totalSpeed = BlockScene.GetComponent<sceneMovement>().speed;
    }
    // Update is called once per frame
    void Update(){}
    public void updateSpeed(){
        BlockScene.GetComponent<sceneMovement>().speed += speedSum;
        totalSpeed = BlockScene.GetComponent<sceneMovement>().speed;
    }
}
