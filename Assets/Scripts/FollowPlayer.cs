using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        offset = new Vector3(0, 2.6f, 13.7f);
        transform.position = player.position + offset;
    }
}
