using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int secondsToWait = 3;
    // Update is called once per frame
    Rigidbody rb;
    MeshRenderer meshRenderer;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();

        meshRenderer.enabled = false;
        rb.useGravity = false;
    }

    void Update()
    {
        if (Time.time > secondsToWait)
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
