using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabgrenadeExplosion : MonoBehaviour{

        public float deathTime ;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            deathTime = deathTime - Time.deltaTime;
            if (deathTime <= 0f)
            {
                Destroy(gameObject);
            }
        }
    }
