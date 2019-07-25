using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private GameObject speedController;
    private GameObject brother;

    private GameObject  useDown;
    private GameObject useUp;

    public GameObject desertL;
    public GameObject estandarDesesert;
    public GameObject desesertShield;
    public GameObject desesertDoublePlattform;
    public GameObject desesertU;

    public GameObject jungleT;
    public GameObject jungleEstandar;
    public GameObject jungleBox;
    public GameObject jungleBowl;
    public GameObject jungleStair;

    public GameObject ruinV;
    public GameObject caveEstandar;
    public GameObject ruinHole;
    public GameObject ruinL;
    public GameObject ruinShield;


    private int randomPrefab;
    public int backGround;

    private bool spawningUp;
    private bool spawningDown;

    private float speed;

    private float sizeUp;
    private float sizeDown;

    private float timeDown;
    private float timeUp;

    private float yUp;
    private float yDown;

    // Start is called before the first frame update
    void Start()
    {
      sizeUp =3*32f;
      sizeDown=3*32f;

      yDown =-38f;
      yUp = 26f;

      timeDown=0f;
      timeUp=0f;
      backGround=1;
      randomPrefab =Mathf.RoundToInt(Random.Range(-0.5f,5.5f));

      spawningUp=true;
      spawningDown=false;

      brother = transform.parent.GetChild(0).gameObject;
      speedController = transform.parent.GetChild(2).gameObject;
      float wid = brother.GetComponent<sceneMovement>().camwidth;
      transform.localPosition = new Vector3(wid/2,0f,0f);
      spawnDown();
    }

    // Update is called once per frame
    void Update()
    {
      speed = speedController.GetComponent<SpeedController>().totalSpeed;
       spawnUp();
       spawnDown();
    }

    private void spawnUp(){
      if(!spawningUp){
        if ( randomPrefab != 5){ // 5= empty
        spawn(selectPrefab(true),new Vector3(transform.position.x,yUp,transform.position.z),transform.rotation);
        }
        randomPrefab =Mathf.RoundToInt(Random.Range(-0.5f,5.5f));
        spawningUp=true;
        timeUp=0f;
      }else{
        if (timeUp >= 1.5f*sizeUp/ (Time.fixedDeltaTime * speed))
            {
          spawningUp= false;
        }else{
          timeUp += Time.fixedDeltaTime;
        }

      }
    }

    private void spawnDown(){
      if(!spawningDown){
        if ( randomPrefab != 5){ // 5= empty
        spawn(selectPrefab(false),new Vector3(transform.position.x,yDown,transform.position.z),transform.rotation);
        }
        randomPrefab =Mathf.RoundToInt(Random.Range(-0.5f,5.5f));
        spawningDown=true;
        timeDown=0f;
      }else{
        if (timeDown >= 1.2f*sizeDown/(Time.fixedDeltaTime*speed)){
          spawningDown= false;
        }else{
          timeDown += Time.fixedDeltaTime;
        }

      }
    }

    private void spawn(GameObject go,Vector3 pos, Quaternion qt){
      GameObject child = Instantiate(go,pos,qt);
      child.transform.parent = brother.transform;
    }

    private GameObject selectPrefab(bool up){
      float size =0f;
      GameObject prefab;
      if( backGround==0){//0 = desert
          if(randomPrefab ==0){// 0 = L
            prefab =desertL;
          }else if(randomPrefab ==1){
            prefab = estandarDesesert;
          }else if(randomPrefab ==2){
            prefab = desesertShield;
          }else if(randomPrefab ==3){
            prefab = desesertDoublePlattform;
          }else {
            prefab = desesertU;
          }
      }else if (backGround ==1){//1=jungle
        if(randomPrefab ==0){// 0 = L
          prefab =jungleT;
        }else if(randomPrefab ==1){
          prefab = jungleEstandar;
        }else if(randomPrefab ==2){
          prefab = jungleBox;
        }else if(randomPrefab ==3){
          prefab = jungleBowl;
        }else {
          prefab = jungleStair;
        }
      }else{
        if(randomPrefab ==0){// 0 = L
          prefab =ruinV;
        }else if(randomPrefab ==1){
          prefab = caveEstandar;
        }else if(randomPrefab ==2){
          prefab = ruinHole;
        }else if(randomPrefab ==3){
          prefab = ruinL;
        }else {
          prefab = ruinShield;
        };
      }
      return prefab;
    }
  }
