using TMPro;
using UnityEngine;

public class enemy : MonoBehaviour
{
	private AudioSource _audiosource;

	public GameObject playerExplosion;

	public float speed;

	public GameObject gameOverScreen;

	public GameObject canvas;

	public GameObject wrongAnsScreen;

	private question question;

	public TMP_Text scoreongo;

	private void Start()
	{
		speed = 0.5f;
		_audiosource = GetComponent<AudioSource>();
		question = GameObject.Find("question").GetComponent<question>();
	}

	private void Update()
	{
		base.transform.Translate(Vector3.down * speed * Time.deltaTime);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		_audiosource.Play();
		if (other.tag == "Player")
		{
			Object.Instantiate(playerExplosion, other.transform.position, Quaternion.identity);
			TMP_Text wrongAnswers = question.wrongAnswers;
			wrongAnswers.text = wrongAnswers.text + question.questions[question.currentQuestion] + " = " + question.answers[question.currentQuestion] + "\n";
			other.gameObject.SetActive(value: false);
			Invoke("showWrongAns", 3f);
			if (question.score > question.currenthighscore)
			{
				PlayerPrefs.SetInt("highscore", question.score);
				question.highscoretext.text = PlayerPrefs.GetInt("highscore").ToString();
				Debug.Log(PlayerPrefs.GetInt("highscore"));
			}
		}
	}

	public void showWrongAns()
	{
		question.Score = scoreongo;
		wrongAnsScreen.SetActive(value: true);
		canvas.SetActive(value: false);
	}
}
