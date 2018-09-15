using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cats : MonoBehaviour
{
    int numberOfCats = 0;
    int totalCats;

    // Use this for initialization
    void Start()
    {
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
            }
            else
            {
                Debug.Log("Save all the cats and return to escape!");
            }
        }
    }
}
