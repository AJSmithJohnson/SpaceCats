using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cats : MonoBehaviour
{
   public int numberOfCats = 0;
    int totalCats;
    public GameObject winPanel;

    // Use this for initialization
    void Start()
    {
        winPanel.SetActive(false);

        GameObject[] cat;
        cat = GameObject.FindGameObjectsWithTag("Cat");
        foreach(GameObject c in cat)
        {
            totalCats++;
        }
        Debug.Log("Number to save " + totalCats);
    }

    public void GetCat()
    {
        numberOfCats += 1;
        Debug.Log(numberOfCats);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (numberOfCats == totalCats)
            {
                Debug.Log("YOU WIN!!");
                winPanel.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                Debug.Log("Save all the cats and return to escape!");
            }
        }
    }
}
