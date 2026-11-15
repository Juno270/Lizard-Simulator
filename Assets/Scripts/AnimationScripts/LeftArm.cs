using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArm : MonoBehaviour
{
    // Start is called before the first frame update

    public Animation Animation;
    public GameObject ThePlayer;

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown("w"))
        {
            GetComponent<Animation>().Play("LeftHand");
        }
        if (Input.GetKeyUp("w"))
        {
            ThePlayer.GetComponent<Animation>().Stop("LeftHand");
        }
    }
}
