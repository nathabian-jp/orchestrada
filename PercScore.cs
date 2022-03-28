using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PercScore : MonoBehaviour {

    public static int percScore = 0;

    Text text;

    // Use this for initialization
    void Start () {

        text = GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {

        text.text = "Perc: " + percScore;

    }
}
