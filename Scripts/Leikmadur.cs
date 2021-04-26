using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Leikmadur : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -10)  // Ef að leikmaður fer lægra ein -10 á y ásnum endurstillist senan
        {
            SceneManager.LoadScene(0);
        }
    }
}
