using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {

    public Camera kamera;
    public Rigidbody2D rb2d;
    public float speed;
    public GameObject man;

    public float maxX;

    private bool canMove;

    // Use this for initialization
    void Start ()
    {
        if (kamera == null)
        {
            kamera = Camera.main;
        }
        if (rb2d == null)
        {
            rb2d = GetComponent<Rigidbody2D>();
        }
        if (man == null)
        {
            man = GetComponent<GameObject>();
        }
        canMove = false;
    }

	// Update is called once physics timestep
	void Update () {
        if (canMove)
        {
            float posX = rb2d.position.x;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                posX -= speed;
                if (posX > -maxX)
                    transform.position = new Vector3(posX, man.transform.localPosition.y, 0.0f);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                posX += speed;
                if (posX < maxX)
                    transform.position = new Vector3(posX, man.transform.localPosition.y, 0.0f);
            }
        }
    }

    public void changeCanMove (bool canMove)
    {
        this.canMove = canMove;
    }

}
