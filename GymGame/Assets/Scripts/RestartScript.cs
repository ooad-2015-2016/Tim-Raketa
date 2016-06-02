using UnityEngine;
using System.Collections;

public class RestartScript : MonoBehaviour {

	public void RestartGame ()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

}
