using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]float timerToDrop = 3f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;
    private void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timerToDrop)
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
