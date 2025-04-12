using UnityEngine;

public class TrgrDropper : MonoBehaviour
{
    [SerializeField]
    GameObject objectToSpawn; // The prefab to spawn

    [SerializeField]
    float spawnYOffset = 1f;  // Amount to offset the spawn position in the Y direction

    [SerializeField]
    Transform spawnPoint;     // Optional: Use this transform for a custom spawn location

    void OnTriggerEnter(Collider other)
    {
        // Optional: you can restrict spawning to certain colliders, e.g. players.
        // if (!other.CompareTag("Player")) return;

        Vector3 spawnPosition;
        Quaternion spawnRotation;

        if (spawnPoint != null)
        {
            // If a spawn point is provided, use its position and rotation
            spawnPosition = spawnPoint.position;
            spawnRotation = spawnPoint.rotation;
        }
        else
        {
            // Otherwise, use the trigger's position plus the Y offset
            spawnPosition = transform.position + new Vector3(0, spawnYOffset, 0);
            spawnRotation = transform.rotation;
        }

        Instantiate(objectToSpawn, spawnPosition, spawnRotation);
        Destroy(gameObject);
    }
}




/*     [SerializeField] GameObject dropper;

    void Awake()
    {
        dropper.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player has entered the trigger");
            dropper.SetActive(true);
        }
    } */

