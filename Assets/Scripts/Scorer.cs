using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You've been hit this many times: " + hits);
        }
    }
}
