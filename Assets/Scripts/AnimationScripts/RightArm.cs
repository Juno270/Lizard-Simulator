using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArm : MonoBehaviour
{
    // Start is called before the first frame update

    public Animation Animation;
    public GameObject ThePlayer;

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown("w"))
        {
            GetComponent<Animation>().Play("RightHand");
        }
        if (Input.GetKeyUp("w"))
        {
            ThePlayer.GetComponent<Animation>().Stop("RightHand");
        }
    }
}
