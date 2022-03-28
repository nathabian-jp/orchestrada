using UnityEngine;
using System.Collections;

public class LaneSwitcher : MonoBehaviour {

    public NoteSpawner topLane;
    public NoteSpawner botLane;

	// Use this for initialization
	void Start () {

        topLane = GetComponent<NoteSpawner>();
        botLane = GetComponent<NoteSpawner>();

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("4"))
        {
            topLane.enabled = !topLane.enabled;
            botLane.enabled = botLane.enabled;
        }

        if (Input.GetButtonDown("5"))
        {
            topLane.enabled = topLane.enabled;
            botLane.enabled = !botLane.enabled;
        }	
	}
}
