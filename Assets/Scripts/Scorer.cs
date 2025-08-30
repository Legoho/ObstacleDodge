using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] private int hit = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if( collision.gameObject.GetComponent<ObjectHit>().hasBeenHit == false)
        {
            hit++;
            Debug.Log("You've bumped into a thing this many times: " + hit);
        }
    }
}
