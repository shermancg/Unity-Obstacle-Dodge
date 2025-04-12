using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]float spinSpeed = 10f;
    [SerializeField]bool spinX = false;
    [SerializeField]bool spinY = false;
    [SerializeField]bool spinZ = false;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xRotate = spinX ? spinSpeed * Time.deltaTime : 0f;
        float yRotate = spinY ? spinSpeed * Time.deltaTime : 0f;
        float zRotate = spinZ ? spinSpeed * Time.deltaTime : 0f;
        
        gameObject.transform.Rotate(xRotate, yRotate, zRotate);
    }
}
