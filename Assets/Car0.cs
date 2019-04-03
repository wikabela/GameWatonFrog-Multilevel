using UnityEngine;

public class Car0 : MonoBehaviour {

	public Rigidbody2D rb;

	public float minSpeed = 3f;
	public float maxSpeed = 5f;

	float speed = 1f;

	void Start ()
	{
        minSpeed+=1f;
        maxSpeed+=1f;
		speed = Random.Range(minSpeed, maxSpeed);
	}

	void FixedUpdate () {
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
	}

}
