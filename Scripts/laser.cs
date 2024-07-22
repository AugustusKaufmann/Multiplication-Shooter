using UnityEngine;

public class laser : MonoBehaviour
{
	public GameObject explosion;

	public float speed = 10f;

	private void Update()
	{
		base.transform.Translate(Vector3.up * speed * Time.deltaTime);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "enemy")
		{
			Object.Instantiate(explosion, other.transform.position, Quaternion.identity);
			other.transform.position = new Vector3(0.76f, 7.41f, 0f);
			Object.Destroy(base.gameObject);
		}
	}
}
