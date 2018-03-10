using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float plane_speed = 10;
    public float projetile_speed = 5000000000;

    void Start () {
	}
	
	void Update () {
        transform.position += transform.forward * Time.deltaTime * plane_speed;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Camera.main.transform.rotation, 50 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject toInstantiate = Resources.Load<GameObject>("Projectile");
            GameObject projectile = Instantiate(toInstantiate, transform.position, Quaternion.identity);
            projectile.name = "Projectile";
            projectile.GetComponent<Rigidbody>().AddForce(transform.forward * projetile_speed, ForceMode.Impulse);
        }
    }
}
