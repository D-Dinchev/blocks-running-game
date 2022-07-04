using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform FollowBy;

    public Vector3 Offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = FollowBy.position + Offset;
    }
}
