using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackWards : MonoBehaviour {

    public float MoveSpeed;
    public float LifeTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);
        LifeTime -= Time.deltaTime;
        if (LifeTime <= 0)
        {
            Destroy(this.gameObject);
        }
	}
}
