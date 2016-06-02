using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {

    public GameObject show;

	public void Pause ()
    {
        Time.timeScale = 0.0f;
        show.SetActive(true);
    }

    public void Resume ()
    {
        show.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
