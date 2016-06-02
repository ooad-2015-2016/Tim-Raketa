using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowHintScript : MonoBehaviour {

    public GameObject hint;
    public GameObject start;
    public GameObject sixty, aHtwenty, twoHfourty, time;

    public void showHint ()
    {
        hint.SetActive(true);
        start.SetActive(false);
        sixty.SetActive(false);
        aHtwenty.SetActive(false);
        twoHfourty.SetActive(false);
        time.SetActive(false);
    }

    public void removeHint ()
    {
        hint.SetActive(false);
        start.SetActive(true);
        sixty.SetActive(true);
        aHtwenty.SetActive(true);
        twoHfourty.SetActive(true);
        time.SetActive(true);
    }
}
