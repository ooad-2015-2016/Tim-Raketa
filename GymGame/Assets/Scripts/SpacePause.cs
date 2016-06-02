using UnityEngine;
using System.Collections;

public class SpacePause : MonoBehaviour {

    public GameObject show;

    void Start ()
    {
        StartCoroutine(Pause());
    }

    IEnumerator Pause ()
    {
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (Time.timeScale == 0)
                {
                    Time.timeScale = 1.0f;
                    show.SetActive(false);
                }
                else
                {
                    show.SetActive(true);
                    Time.timeScale = 0.0f;
                }
            }
            yield return null;
        }
    }

}
