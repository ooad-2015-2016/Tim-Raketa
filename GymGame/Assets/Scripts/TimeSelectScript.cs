using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeSelectScript : MonoBehaviour {

    public Button klik;
    GameObject go;

    public void selectTime ()
    {
        go = GameObject.Find("GameController");
        switch (klik.tag)
        {
            case "60":
                go.GetComponent<GameControllerScript>().timeLeft = 60.0f;
                break;
            case "120":
                go.GetComponent<GameControllerScript>().timeLeft = 120.0f;
                break;
            case "240":
                go.GetComponent<GameControllerScript>().timeLeft = 240.0f;
                break;

        }
    }
}
