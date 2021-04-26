using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kassi : MonoBehaviour
{
    // Held utan um stig ef ég vildi halda utan um stig og tek inn sprengingu
    // public Text countText;
    // private static int count;
    public GameObject sprenging;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "kula")
        {
            Sprengin();   // Ef kúlan snertir kassann fer sprenging í gang og ég bæti við stigin sem að uppfærist síðan í gegnum SetCountText
            Debug.Log("varð fyrir kúlu");
            // count = count + 1; //færð stig
            // SetCountText(); //kallar í aðferðina
        }
    }
    // Þessi aðferð uppfærir stigin
    void SetCountText()//hér er aðferðin
    {
        //countText.text = "Stig: " + count.ToString();
    }
    // Þessi aðferð lætur sprenginguna í gang með því að finna staðsetningu kassans og láta sprenginuna springa þar
    void Sprengin()
    {
        Instantiate(sprenging, transform.position, transform.rotation);
    }
}
