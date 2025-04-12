using UnityEngine;

public class TriggerProjectiles : MonoBehaviour
{
    [SerializeField] GameObject projectile;

    void Awake()
    {
        projectile.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player has entered the trigger");
            projectile.SetActive(true);
        }
    }
}
