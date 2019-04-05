using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Rigidbody rb;
    public playMovement movement;
    public FollowPlayer camMovement;
    public Score scoreUpdate;
    public PhysicMaterial Slippery;
    public GameObject EnergyFieldPlane;
    public Transform player;
    public GameObject ObstacleCollided;

    void Start()
    {
        //Slippery.staticFriction = 0;
        //Slippery.dynamicFriction = 0;
    }

    void OnCollisionEnter(Collision collisioninfo)
    {
        if(collisioninfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            //rb.AddExplosionForce(5000,rb.position,5);
            camMovement.enabled = false;
            scoreUpdate.enabled = false;
            //Slippery.staticFriction = 0.9f;
            //Slippery.dynamicFriction = 0.9f;
            //collisioninfo.gameObject.prefa
            //collisioninfo.gameObject.GetComponent<Material>().color = Color.red;
            //Instantiate(ObstacleCollided, collisioninfo.transform.position, collisioninfo.transform.rotation);
            //Destroy(collisioninfo.gameObject);
            //Vector3 v = new Vector3(0, 0, -5);
            //Instantiate(EnergyFieldPlane, player);
        }
    }
}
