using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting2 : MonoBehaviour
{
    public GameObject bullet;  // Tek inn kúlu
    public float speed = 100f; // Set hraða hennar
    void FixedUpdate()
    {
        if (Input.GetKey("f"))  // Ef að þú ýtir á f
        {
            GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;  // geri kúluna tilbúna að skjóta frá stöðunni sem að ég er að horfa
            //GameObject instBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();  // Tek inn rigidbodyið
            instBulletRigidbody.AddForce(transform.forward * speed);  // Skýt kúlunni áfram
            Destroy(instBullet, 0.5f);//kúlu eytt eftir 0.5sek
        }
    }
}
