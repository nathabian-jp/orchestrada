using UnityEngine;
using System.Collections;

public class NoteBarrier : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("SNote") || other.gameObject.CompareTag("BNote") || other.gameObject.CompareTag("WNote") || other.gameObject.CompareTag("PNote") || other.gameObject.CompareTag("Star"))
        {
            Destroy(other.gameObject);
        }
    }
}
