using UnityEngine;

[ExecuteAlways]
public class CameraFollow2D : MonoBehaviour
    {
        public float FollowSpeed = 2f;
        private Vector3 TargetPos;
        public GameObject FollowTarget;
        void FixedUpdate()
        {
        TargetPos = new Vector3(FollowTarget.transform.position.x, FollowTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, TargetPos, FollowSpeed * Time.deltaTime);
        }
    }
