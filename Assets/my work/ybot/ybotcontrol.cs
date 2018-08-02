using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ybotcontrol : MonoBehaviour {

    int pose;
    Animator myani;
    float cont = 15f;

    // Use this for initialization
    void Start()
    {
        pose = 0;
        myani = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cont > 0)
        {
            cont -= Time.deltaTime;
        }
        else
        {
            pose = Random.Range(1, 5);
            myani.SetInteger("anims", pose);
            cont = 15f;
        }
    }

}
