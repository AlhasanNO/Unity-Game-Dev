using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Player
{
    public string playerName;
    public int health;
    public static int playerCount = 0;

    public void InitializePlayer(string name, int initialhealth)
    {
        name = playerName;
        initialhealth = health;
        playerCount++;
    }

    public void Heal(int amount)
    {
        if ((health + amount) > 100)
        {
            health = 100;
            Debug.Log($"{playerName} health is full");
        }
        else
        {
            health += amount;
            Debug.Log($"{amount} Health added to {playerName}");
        }
    }

    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100;
            Debug.Log($"{playerName} Fully healed");
        }

    }

    public static void ShowPlayerCount()
    {
        Debug.Log($"Player Count: {playerCount}");
    }
}