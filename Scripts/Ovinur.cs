using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ovinur : MonoBehaviour
{
    // Næ í leikmanninn og geri nokkrar breytur
    public Transform player;
    private Rigidbody rb;
    private Vector3 movement;
    public float hradi = 5f;

    // Held utan um stigagjöf og sprengingu
    //public Text countText;
    //private static int count;
    public Text livesText;
    private int countLives;
    public GameObject sprenging;
    // Keyrir einu sinni þegar leikurinn byrjar
    void Start()
    {
        // Næ í rigidbody óvinins sjálfans með this
        rb = this.GetComponent<Rigidbody>();
        countLives = 5;  // Set lífin á 5 líf
        SetCountLives();
    }

    // Þetta kallast á hverjum frame
    void Update()
    {
        // held utan um staðsetningu leikmanns
        Vector3 stefna = player.position - transform.position;
        stefna.Normalize();  // Fæ eitt gildi til að vinna með
        movement = stefna;  // Tek þetta síðan í aðra breytu
    }
    private void FixedUpdate()
    {
        Hreyfing(movement);  // Kalla á hreyfing klasann á hverjum ramma sem að tölvan þín keyrir á
    }
    void Hreyfing(Vector3 stefna)  // Tek inn stefnu leikmanns
    {
        rb.MovePosition(transform.position + (stefna * hradi * Time.deltaTime));  // Færi rigidbody óvins á staðsetningu leikmanns
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "kula")  // Ef að kúla hittir óvin
        {
            Sprengin();  // Sprenging fer í gang
            Debug.Log("óvinur varð fyrir kúlu");
            // count = count + 1; //færð stig
            // SetCountText(); //kallar í aðferðina
        }
        if (collision.collider.tag == "Player")  // Ef að leikmaður rekst í óvin
        {
            Debug.Log("ovinur hitti player");
            countLives = countLives - 1; // Leikmaður missir líf
            SetCountLives();  // Uppfæri lífunum með klasanum
            if (countLives < 1)  // Ef leikmaður klárar líf sín fer hann í nýja senu
            {
                SceneManager.LoadScene(2);
            }
        }
    }
    // Þessi aðferð uppfærir stigin
    void SetCountText() //hér er aðferðin
    {
        //countText.text = "Stig: " + count.ToString();
    }
    // Þessi aðferð uppfærir lífunum
    void SetCountLives() //hér er aðferðin
    {
        livesText.text = "Líf: " + countLives.ToString();
    }
    // Þessi aðferð lætur sprenginguna í gang með því að finna staðsetningu kassans
    void Sprengin()
    {
        Instantiate(sprenging, transform.position, transform.rotation);
    }
}
