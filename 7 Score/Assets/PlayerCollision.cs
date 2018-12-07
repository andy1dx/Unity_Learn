using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public playerMovement movement;

	// Use this for initialization
	void OnCollisionEnter (Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
	}
	

}
