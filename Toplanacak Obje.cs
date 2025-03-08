using UnityEngine;

public class Topla : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
      transform.Rotate(new Vector3(15,30,45)*Time.deltaTime) ;
      

    }
}
