using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_scean : MonoBehaviour {

    public void changemenuscrean(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
