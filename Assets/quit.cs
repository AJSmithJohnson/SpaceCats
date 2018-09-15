using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour {

	public void Credits()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Credits");
    }
}
