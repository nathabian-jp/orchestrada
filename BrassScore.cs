using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BrassScore : MonoBehaviour {

    public static int brassScore = 0;

    Text text;

    // Use this for initialization
    void Start () {

      text = GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {

        text.text = "Brass: " + brassScore;

    }
}
