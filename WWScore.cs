using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WWScore : MonoBehaviour {

    public static int wwScore = 0;

    Text text;

    // Use this for initialization
    void Start () {

        text = GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {

        text.text = "WW: " + wwScore;

    }
}
