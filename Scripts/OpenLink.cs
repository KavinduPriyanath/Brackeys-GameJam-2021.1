using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    
    public void OpenFb ()
    {
        Application.OpenURL("https://www.facebook.com/KaviGames-103803648403246");
    }

    public void OpenTwitter ()
    {
        Application.OpenURL("https://twitter.com/GamesKavi");
    }

}
