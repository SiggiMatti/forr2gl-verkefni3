using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public Rigidbody rb;  // Tek inn rigidbody kúlunnar

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);  // Sýni það sem að kúlan klessti á

        if (collision.collider.tag == "kassi" || collision.collider.tag == "ovinur")  //  Ef að kúlan hitti kassa eða óvin
        {
            Destroy(collision.gameObject);  // Eyði kúlunni
            gameObject.SetActive(false);
            Debug.Log("hitti kassa");
            
        }

        else if (collision.collider.name != "byssa")  // Ef að kúlan lendir á einvherju öðru eyði ég henni
        {
            gameObject.SetActive(false);
            // Debug.Log("kúlu líka eytt eytt");
        }
    }
}
