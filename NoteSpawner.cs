using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NoteSpawner : MonoBehaviour
{
    //creating and accessing the list var
    List<GameObject> prefabList = new List<GameObject>();
    int prefabIndex;
    int prefabIndex2;
    int numberOfSpawns;

    //notes
    public GameObject sNoteClone;
    public GameObject bNoteClone;
    public GameObject pNoteClone;
    public GameObject wNoteClone;
    public GameObject starClone;

    //time var
    public float noteSpeed = 0f;
    public float delay = 3f;
    float time = 0f;

    

    // Use this for initialization
    void Start()
    {

        time = delay;

        //adding notes to list
        prefabList.Add(sNoteClone);
        prefabList.Add(bNoteClone);
        prefabList.Add(wNoteClone);
        prefabList.Add(pNoteClone);
        prefabList.Add(starClone);
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;

        // We've completed our delay, so spawn and reset the timer
        if (time >= delay)
        {
            // Subtracting rather than setting to zero keeps us from losing the little bit of time
            //  if the time isn't exactly the delay
            time -= delay;

            //numberOfSpawns creates the chord
            numberOfSpawns = UnityEngine.Random.Range(1, 3);
            prefabIndex = UnityEngine.Random.Range(0, 5);
            
           
            if (numberOfSpawns == 1)
            {
                // Create our new item
                GameObject spawn = Instantiate(prefabList[prefabIndex]) as GameObject;
                // Give it the correct position
                spawn.transform.position = new Vector3(1.871f, 0.1f, 0);
                // Give it a semi-random downward push
                spawn.GetComponent<Rigidbody2D>().AddForce(new Vector2(-noteSpeed, 0));
            }

            if (numberOfSpawns == 2)
            {
                
                prefabIndex2 = UnityEngine.Random.Range(0, 5);
                if (prefabIndex == prefabIndex2)
                {
                    // Create our new item
                    GameObject spawn = Instantiate(prefabList[prefabIndex]) as GameObject;
                    // Give it the correct position
                    spawn.transform.position = new Vector3(1.871f, 0.1f, 0);
                    // Give it a semi-random downward push
                    spawn.GetComponent<Rigidbody2D>().AddForce(new Vector2(-noteSpeed, 0));
                }
                else
                {
                    // Create our new item
                    GameObject spawn = Instantiate(prefabList[prefabIndex]) as GameObject;
                    // Give it the correct position
                    spawn.transform.position = new Vector3(1.871f, -0.1f, 0);
                    // apply force to the rigid body with correct speed
                    spawn.GetComponent<Rigidbody2D>().AddForce(new Vector2(-noteSpeed, 0));

                    // Create our new item
                    GameObject spawn2 = Instantiate(prefabList[prefabIndex2]) as GameObject;
                    // Give it the correct position
                    spawn2.transform.position = new Vector3(1.871f, 0.3f, 0);
                    // apply force to the rigid body with correct speed
                    spawn2.GetComponent<Rigidbody2D>().AddForce(new Vector2(-noteSpeed, 0));
                }
            }
        }
    }
}