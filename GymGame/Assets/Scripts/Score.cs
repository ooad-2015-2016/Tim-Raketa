using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {


    public AudioClip yes;
    public AudioClip no;

    public Text scoreText;
    int score;

	// Use this for initialization
	void Start () {
        score = 0;
        UpdateScore();
	}

    void OnTriggerEnter2D (Collider2D collider)
    {
        Vector3 position = collider.transform.position;

        switch (collider.tag)
        {
            case "APPLE":
                playAudio(1, position);
                score += 1;
                break;
            case "EGGS":
                playAudio(1, position);
                score += 3;
                break;
            case "FISH":
                playAudio(1, position);
                score += 5;
                break;
            case "CHICKEN":
                playAudio(1, position);
                score += 10;
                break;
            case "FRIES":
                playAudio(2, position);
                score -= 10;
                break;
            case "COLA":
                playAudio(2, position);
                score -= 20;
                break;
            case "HAMBURGER":
                playAudio(2, position);
                score -= 30;
                break;
            case "CIGARES":
                playAudio(2, position);
                score -= 40;
                break;
            case "FIVESECONDS":
                playAudio(1, position);
                addSeconds(5.0f);
                break;
            case "TENSECONDS":
                playAudio(1, position);
                addSeconds(10.0f);
                break;
            case "TVENTYSECONDS":
                playAudio(1, position);
                addSeconds(20.0f);
                break;
        }
        UpdateScore();
    }
	
	// Update is called once per frame
	void UpdateScore () {
        if (score < 0) scoreText.color = Color.red;
        else scoreText.color = Color.green;
        scoreText.text = "SCORE:\n" + score;
	}

    void addSeconds(float n)
    {
        GameObject.Find("GameController").GetComponent<GameControllerScript>().timeLeft += n;
    }

    void playAudio (int clip, Vector3 position)
    {
        if (clip == 1)
            AudioSource.PlayClipAtPoint(yes, position);
        else if (clip == 2)
            AudioSource.PlayClipAtPoint(no, position);
    }
}
