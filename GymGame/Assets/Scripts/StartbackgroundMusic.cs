using UnityEngine;
using System.Collections;

public class StartbackgroundMusic : MonoBehaviour {

    public AudioSource audio;

	public void StartBackgroundMusic ()
    {
        audio.Play();
    }

    public void StopBackgroundMusic ()
    {
        audio.Stop();
    }

    public void AdjustVolume (float volume)
    {
        audio.volume = volume;
    }
}
