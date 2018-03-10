using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMe : MonoBehaviour {
    public float delay;
	void Start () {
	}
	
	void Update () {
        delay -= Time.deltaTime;
        if (delay <= 0)
            Destroy(gameObject);
	}
}
