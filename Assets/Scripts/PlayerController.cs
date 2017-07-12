using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    //public Text ScoreLabel;
    //public Text WinLabel;

    private int currentScore = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //UpdateScore();
        //WinLabel.text = string.Empty;
    }
	
	// Fixed update is called before physics computation
	void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.AddForce(movement * speed);
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            currentScore++;
            //UpdateScore();
        }
    }

    //private void UpdateScore()
    //{
    //    ScoreLabel.text = currentScore > 1 ? 
    //        string.Format("Score : {0} pts", currentScore) : 
    //        string.Format("Score : {0} pt", currentScore);

    //    if (currentScore >= 2)
    //    {
    //        WinLabel.text = "Kappa";
    //    }
    //}
}