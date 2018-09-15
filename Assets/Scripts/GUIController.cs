using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIController : MonoBehaviour {

    public Image image;
    public Text text;


	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        text.text = Mathf.Round(PlayController.main.timeLeft) + "s";
        image.rectTransform.rotation = Quaternion.Euler(0, 0, Gravity.angle);
    }
}
