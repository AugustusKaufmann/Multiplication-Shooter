using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
	private int count;

	public GameObject canvas;

	private question question;

	public GameObject ship;

	public GameObject asteroid;

	public GameObject square;

	public GameObject newtext1;

	public GameObject newtext2;

	public GameObject player;

	public GameObject startscreen;

	public GameObject music;

	private enemy Enemyscript;

	public void Start()
	{
		question = GameObject.Find("question").GetComponent<question>();
		Enemyscript = GameObject.Find("Asteroid").GetComponent<enemy>();
	}

	public void Update()
	{
	}

	public void Play()
	{
		SceneManager.LoadScene(0);
		Time.timeScale = 1f;
	}

	public void SoundOff()
	{
		count++;
		if (count % 2 == 0 && count != 0)
		{
			AudioListener.volume = 1f;
		}
		else
		{
			AudioListener.volume = 0f;
		}
	}

	public void gameStart()
	{
		Time.timeScale = 1f;
		canvas.SetActive(value: true);
		square.SetActive(value: true);
		ship.SetActive(value: true);
		newtext1.SetActive(value: true);
		newtext2.SetActive(value: true);
		player.SetActive(value: true);
		startscreen.SetActive(value: false);
		music.SetActive(value: true);
	}
}
