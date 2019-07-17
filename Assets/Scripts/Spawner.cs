using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private GameObject brother;

    private GameObject  useDown;
    private GameObject useUp;

    public GameObject  jungleDown;
    public GameObject  jungleUp;

    public GameObject  desertDown;
    public GameObject  desertUp;

    private int backGround;
    private bool spawningUP;
    private bool spawningDown;

    private float time1;
    private float time2;

    // Start is called before the first frame update
    void Start()
    {
      time1=0;
      time2=0;
      backGround=0;
      spawningUP=false;
      spawningDown=false;
      brother = transform.parent.GetChild(0).gameObject;
      setBlocks();
    }

    // Update is called once per frame
    void Update()
    {
      spawnUp();
      spawnDown();
    }

    private void spawnUp(){

    }
    private void spawnDown(){

    }

    private void setBlocks(){
      if (backGround==0){
        useUp =jungleUp;
        useDown = jungleDown;
      }else if (backGround==1){
        useUp =desertUp;
        useDown = desertDown;
      }
    }
    private void spawn(GameObject go,Vector3 pos, Quaternion qt){
      GameObject child = Instantiate(go,pos,qt);
      child.transform.parent = brother.transform;
    }
}
