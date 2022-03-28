using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StringsScore : MonoBehaviour {

    public static int stringsScore = 0;

    Text text;

    // Use this for initialization
    void Start () {

        text = GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {

        text.text = "Strings: " + stringsScore;

    }
}
