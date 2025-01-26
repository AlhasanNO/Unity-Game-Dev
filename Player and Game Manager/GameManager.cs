using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player falah = new Player();
        Player fathi = new Player();

        falah.InitializePlayer("Falah", 100);
        fathi.InitializePlayer("Fathi", 80);

        falah.Heal(true);
        fathi.Heal(60);

        Player.ShowPlayerCount();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
