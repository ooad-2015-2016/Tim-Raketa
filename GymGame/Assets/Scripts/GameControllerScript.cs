using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class GameControllerScript : MonoBehaviour {

    public float maxX;
    public float y;
    public GameObject[] objects;
    public GameObject[] hazards;
    public GameObject[] times;
    public float timeLeft;
    public Text timeText;

    //pocetak
    public GameObject startGameImage;
    public GameObject chooseTimeText;
    public GameObject time1, time2, time3;
    public GameObject startButton;
    public GameObject pauseButton;
    //kraj
    public GameObject yourScoreText;
    public GameObject gameOverImage;
    public GameObject restartButton;
    public bool playing;

    private int br;
    private float levelTime;
    private float startingTime;


	// Use this for initialization
	void Start () {
        y = transform.position.y;
        if (maxX == 0) maxX = 7.8f;
        br = 0;
        timeText.color = Color.green;
        timeText.text = "TIME LEFT:\n" + Mathf.RoundToInt(timeLeft);
        playing = false; //zbog timera
    }

    void FixedUpdate ()
    {
        if (playing)
        {
            timeLeft -= Time.deltaTime;
            levelTime -= Time.deltaTime;
            if (timeLeft < 0) timeLeft = 0; //da ne ide u minus
            if (timeLeft < 10) timeText.color = Color.red;
            else timeText.color = Color.green;
            timeText.text = "TIME LEFT:\n" + Mathf.RoundToInt(timeLeft);
        }
    }

    public void startGame ()
    {
        //uklanjamo sve sa start screena i pokrecemo spawn
        //prije svega ako nije odabrano vrijeme od strane korisnika postavljamo default na 60s
        if (timeLeft < 60.0f)
            timeLeft = 60.0f;
        levelTime = timeLeft; //ovo koristi da se nakon određenog vremena ubrza instanciranje hazarda bez obzira na pravo vrijeme
        startingTime = timeLeft / 2;

        startGameImage.SetActive(false);

        pauseButton.SetActive(true);
        //pokretanje tipa
        GameObject.Find("Character").GetComponent<CharacterMove>().changeCanMove(true);
        //pustiti background muziku
        GameObject.Find("Background").GetComponent<StartbackgroundMusic>().StartBackgroundMusic();

        playing = true;
        //zbog spacePause ako ostane pauzirane to jeste timeScale == 0:
        if (Time.timeScale == 0.0f)
            Time.timeScale = 1.0f;
        StartCoroutine(Spawn()); 
    }

    public void Quit ()
    {
        Application.Quit();
    }
	
	IEnumerator Spawn ()
    {
        //sacekamo malo prije nego se generise prvi objekat
        yield return new WaitForSeconds(1.1f);

        while (timeLeft > 0)
        {
            //objekti koje treba instancirati
            GameObject objekat1 = objects[UnityEngine.Random.Range(0, objects.Length)];
            GameObject objekat2 = hazards[UnityEngine.Random.Range(0, hazards.Length)];
            GameObject objekat3 = hazards[UnityEngine.Random.Range(0, hazards.Length)];
            Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(-maxX, maxX), y, 0.0f);
            Quaternion spawnRotation = Quaternion.identity; //bez rotacije

            //instanciranje objekata, 2 hazarda na 1 objekat. time objekat ide nakon 15-25 ovih instanciranja
            Instantiate(objekat1, spawnPosition, spawnRotation);
            spawnPosition = new Vector3(UnityEngine.Random.Range(-maxX, maxX), y, 0.0f);
            yield return new WaitForSeconds(UnityEngine.Random.Range(0.1f, 0.45f));
            Instantiate(objekat2, spawnPosition, spawnRotation);

            if (levelTime < startingTime)
            {
                spawnPosition = new Vector3(UnityEngine.Random.Range(-maxX, maxX), y, 0.0f);
                yield return new WaitForSeconds(UnityEngine.Random.Range(0.1f, 0.45f));
                Instantiate(objekat3, spawnPosition, spawnRotation);
            }

            br++;

            if (br > UnityEngine.Random.Range(15, 26))
            {
                Vector3 timeSpawnPos = new Vector3(
                UnityEngine.Random.Range(-maxX, maxX),
                y,
                0.0f
                );
                Instantiate(times[UnityEngine.Random.Range(0, times.Length)], timeSpawnPos, spawnRotation);
                br = 0;
            }
            yield return new WaitForSeconds(UnityEngine.Random.Range(0.6f, 1.5f));   
        }

        //ovdje je kraj i moramo prikazati objekte sa canvasa
        yield return new WaitForSeconds(1.5f);
        //treba dohvatiti text score
        string temp = GameObject.Find("Score").GetComponent<Text>().text;
        yourScoreText.GetComponent<Text>().text = "Your Score:" + temp.Substring(6);
        gameOverImage.SetActive(true);

        //zaustavljamo muziku:
        GameObject.Find("Background").GetComponent<StartbackgroundMusic>().StopBackgroundMusic();
        pauseButton.SetActive(false);
    }

}
