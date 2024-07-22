using TMPro;
using UnityEngine;

public class question : MonoBehaviour
{
	public TMP_Text wrongAnswers;

	private AudioSource _audiosource;

	public enemy Enemy;

	public TMP_Text Score;

	public int score;

	public TMP_InputField input;

	public string inputText;

	public int currentQuestion;

	public TMP_Text questionText;

	public string[] questions;

	public string[] answers;

	public int noofQuestions = 132;

	public GameObject laserPrefab;

	private Animator blueanimator;

	private Animator pinkanimator;

	public GameObject wrongsoundPrefab;

	public int currenthighscore;

	public TMP_Text highscoretext;

	public TMP_Text highscoretext2;

	private void Start()
	{
		currenthighscore = PlayerPrefs.GetInt("highscore");
		Time.timeScale = 0f;
		input.Select();
		setQuestions();
		_audiosource = GetComponent<AudioSource>();
		blueanimator = GameObject.Find("Bluebg").GetComponent<Animator>();
		pinkanimator = GameObject.Find("Pinkbg").GetComponent<Animator>();
	}

	private void Update()
	{
		Score.text = score.ToString();
		if (Input.GetKeyDown(KeyCode.Return))
		{
			input.ActivateInputField();
			scoring();
		}
		Invoke("updateinputselect", 0.5f);
		highscoretext.text = PlayerPrefs.GetInt("highscore").ToString();
		highscoretext2.text = PlayerPrefs.GetInt("highscore").ToString();
	}

	public void setQuestions()
	{
		currentQuestion = Random.Range(0, 132);
		questionText.text = questions[currentQuestion];
	}

	public void scoring()
	{
		inputText = input.text;
		Debug.Log(inputText);
		Debug.Log(answers[currentQuestion]);
		if (answers[currentQuestion] == inputText)
		{
			setQuestions();
			Object.Instantiate(laserPrefab, new Vector3(0.71f, -1.19f, 0f), Quaternion.identity);
			_audiosource.Play();
			score++;
			input.text = "";
			if (score % 10 == 0 && score != 0)
			{
				Enemy.speed += 0.4f;
				colorBg();
			}
		}
		else if (inputText != "")
		{
			TMP_Text tMP_Text = wrongAnswers;
			tMP_Text.text = tMP_Text.text + questions[currentQuestion] + " = " + answers[currentQuestion] + "\n";
			setQuestions();
			score += -1;
			input.text = "";
			Object.Instantiate(wrongsoundPrefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
			Debug.Log("NO");
		}
		input.Select();
		Debug.Log(Enemy.speed);
	}

	public void updateinputselect()
	{
		input.ActivateInputField();
	}

	public void bgChangebluetopink()
	{
		blueanimator.SetBool("colorchange", value: true);
	}

	public void bgChangepinktored()
	{
		blueanimator.SetBool("colorchange", value: false);
		pinkanimator.SetBool("colorchange", value: true);
	}

	public void bgChangeredtopink()
	{
		pinkanimator.SetBool("colorchange", value: false);
		pinkanimator.SetBool("backtonorm", value: true);
	}

	public void bgChangepinktoblue()
	{
		pinkanimator.SetBool("backtonorm", value: false);
		blueanimator.SetBool("backtonorm", value: true);
	}

	public void colorBg()
	{
		if (score % 10 == 0 && score != 0)
		{
			Invoke("bgChangebluetopink", 5f);
			Invoke("bgChangepinktored", 30f);
			Invoke("bgChangeredtopink", 55f);
			Invoke("bgChangepinktoblue", 80f);
		}
	}
}
