using UnityEngine;

public class Dropper : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Dropper hit the player");
            Destroy(gameObject);
        }
    }

    /*     [SerializeField]float dropTimer = 0f;

        MeshRenderer myMeshRenderer;
        Rigidbody myRigidbody;

        void Start()
        {
            myMeshRenderer = GetComponent<MeshRenderer>();
            myRigidbody = GetComponent<Rigidbody>();
            myMeshRenderer.enabled = false;
            myRigidbody.useGravity = false;

        }

        void Update()
        {
            if (Time.time > dropTimer)
            {
                myMeshRenderer.enabled = true;
                myRigidbody.useGravity = true;
            }
        } */
}
