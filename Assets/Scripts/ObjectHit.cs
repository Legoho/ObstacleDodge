using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public bool hasBeenHit = false;
    
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Something hit me!");
        if(collision.gameObject.tag=="Player" && !hasBeenHit)
        {
            hasBeenHit = true;
            ChangeColor();
        }
        
    }
    void ChangeColor()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
