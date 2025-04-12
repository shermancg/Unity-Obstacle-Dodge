using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField]float prjctlSpeed = 1f;
    Vector3 targetPos;


    void Start()
    {
        targetPos = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        ProjectileLocation();
        DestroyWhenReached();
    }

    void ProjectileLocation()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, prjctlSpeed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if (transform.position == targetPos)
        {
            Destroy(gameObject);
        }
    }
}
