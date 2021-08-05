using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L2PD : MonoBehaviour
{
    public void Redirect()
    {
        SceneManager.LoadScene("Level02Death");
    }
}
