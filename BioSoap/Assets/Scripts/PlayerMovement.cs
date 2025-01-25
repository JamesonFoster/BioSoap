using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	Transform cam;
	public float speed = 2;

	private void Start()
	{
		cam = Camera.main.transform;
	}

	void Update()
	{
		Vector3 forwardMovement = cam.forward * Input.GetAxis("Vertical");
		Vector3 horizontalMovement = cam.right * Input.GetAxis("Horizontal");

		Vector3 movement = Vector3.ClampMagnitude(forwardMovement + horizontalMovement, 1);
		transform.Translate(movement * speed * Time.deltaTime, Space.World);
	}
}
