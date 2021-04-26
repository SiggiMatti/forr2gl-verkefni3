using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Peningur : MonoBehaviour
{
    // Tek inn textabreytu og held utan um stig með count
    public Text countText;
    private static int count;
    // Update is called once per frame
    void Start()
    {
        // Þegar forritið byrjar eru stigin 0 og læt það í aðferðina sem uppfærir stigin
        count = 0;
        SetCountText();
    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 80, 0) * Time.deltaTime);  // Læt peninginn snúast í hringi
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")  // Kíki hvort að leikmaður snerti peninginn
        {
            Destroy(gameObject);  // Eyði peningnum
            gameObject.SetActive(false);
            Debug.Log("Tók upp pening");
            count = count + 1; //færð stig
            SetCountText(); //kallar í aðferðina sem uppfærir stigunum
            if (count == 20)
            {
                SceneManager.LoadScene(3);
            }
        }
    }
    void SetCountText()//hér er aðferðin sem uppfærir stigunum
    {
        countText.text = "Stig: " + count.ToString();
    }
}
