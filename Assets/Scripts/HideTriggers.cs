using UnityEngine;

public class hideTriggers : MonoBehaviour
{
    void Start()
    {
        // Find all GameObjects with the "IsTrigger" tag
        GameObject[] triggerObjects = GameObject.FindGameObjectsWithTag("IsTrigger");

        foreach (GameObject obj in triggerObjects)
        {
            // Try to get the MeshRenderer component
            MeshRenderer meshRenderer = obj.GetComponent<MeshRenderer>();
            if (meshRenderer != null)
            {
                // Disable the MeshRenderer
                meshRenderer.enabled = false;
            }
        }
    }
}
