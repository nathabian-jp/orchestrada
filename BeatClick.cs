using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class BeatClick : MonoBehaviour {

    /*
    Button 0 == A Button on controller
    Button 1 == B Button on controller
    Button 2 == X Button on controller
    Button 3 == Y Button on controller
    */

    public static int stringsScore = 0;
    public static int wwScore = 0;
    public static int brassScore = 0;
    public static int percScore = 0;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerStay2D(Collider2D other)
    {
        //this counts for any note and adds to whichever button you press
        if (other.gameObject.CompareTag("Star"))
        {
            if (Input.GetButtonDown("0") || Input.GetButtonDown("1") || Input.GetButtonDown("2") || Input.GetButtonDown("3"))
            {
                if (Input.GetButtonDown("0"))
                {
                    BrassScore.brassScore++;
                    Destroy(other.gameObject);
                }
                if (Input.GetButtonDown("1"))
                {
                    StringsScore.stringsScore++;
                    Destroy(other.gameObject);
                }
                if (Input.GetButtonDown("2"))
                {
                    WWScore.wwScore++;
                    Destroy(other.gameObject);
                }
                if (Input.GetButtonDown("3"))
                {
                    PercScore.percScore++;
                    Destroy(other.gameObject);
                }
            }
        }
        if (other.gameObject.CompareTag("BNote"))
        {
            if (Input.GetButtonDown("0"))
            {
                BrassScore.brassScore++;
                Destroy(other.gameObject);
            }
        }

        if (other.gameObject.CompareTag("SNote"))
        {
            if (Input.GetButtonDown("1"))
            {
                StringsScore.stringsScore++;
                Destroy(other.gameObject);
            }
        }

        if (other.gameObject.CompareTag("WNote"))
        {
            if (Input.GetButtonDown("2"))
            {
                WWScore.wwScore++;
                Destroy(other.gameObject);
            }
        }

        if (other.gameObject.CompareTag("PNote"))
        {
            if (Input.GetButtonDown("3"))
            {
                PercScore.percScore++;
                Destroy(other.gameObject);
            }
        }

    }
}
