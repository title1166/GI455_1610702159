using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class assignment_1 : MonoBehaviour
{
    public string n;
    public GameObject inputnakah;
    public GameObject outputnakub;
    public void assignmenteieizahahaplus()
    {

        n = inputnakah.GetComponent<Text>().text;
        if (n == "cold" || n == "hot" || n == "burn" || n == "freeze" || n == "cool")
        {
            outputnakub.GetComponent<Text>().text = n+ " is found";
        }

        else
        {
            outputnakub.GetComponent<Text>().text = n+ " is not found";
        }

    }
}
