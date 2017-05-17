using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Collect : MonoBehaviour {

    int count;
    public Text countText;
    public Text winText;
    public Text timeCount;
    public float min, sec;

    public void start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
        timeCount = GetComponent<Text>() as Text;
    }

    public void Update()
    {
        min = (int)(Time.time/60f);
        sec = (int)(Time.time % 60f);
        timeCount.text = min.ToString("00") + ":" + sec.ToString("00");
    }

	void OnTriggerEnter (Collider other) {

        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            

        }

	}

    void SetCountText()
    {
        countText.text = "You have collected " + count.ToString() + " paper birds!";
        if (count >= 4)
        {
            winText.text = "You win!";
        }
    }

}
 //Destroy(other.gameObject);