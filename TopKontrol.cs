using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    Rigidbody fizik;
    public int hiz;
    int score = 0;
    public int toplanilacakObjesayisi;
    public Text SCORETEXT;
    



    void Start()
    {
        fizik = GetComponent<Rigidbody>();

    }


    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw ("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec=new Vector3(yatay,0,dikey);

        fizik.AddForce(vec * hiz);



        // Debug.Log("yatay = " + yatay+  "    dikey = "  +dikey);

    }
    void OnTriggerEnter (Collider other)    
    {
      
        if (other.gameObject.tag == "engel")
        {
            other.gameObject.SetActive(false);
            score++;
            SCORETEXT.text = "SCORE = " + score;
            


            if(score == toplanilacakObjesayisi)
            {
                Debug.Log("GAME DONE");

            }


        }

    }
}
