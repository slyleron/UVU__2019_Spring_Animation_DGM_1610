using System;
using System.Collections;
using UnityEngine;

public class simple_move : MonoBehaviour {

    public float jupmhight=10;
    float up = 0;
    float right = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //up down left right
        
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        right += h;
        //comment this line out to have it not move up and down
        up += v;
        transform.position = new Vector3(right, up, 0);
       // if(Collision2D.)
       // { Debug.Log("hit"); }

        
        //Jump code
        ///if (up < 5) { up += v; }
        //else
       //{
        //    up += -0.01;
       //}
    }

   

}
