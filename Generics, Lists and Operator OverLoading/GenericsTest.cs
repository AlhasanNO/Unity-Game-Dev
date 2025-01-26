using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    void Start()
    {
        GameContainer<string> container = new GameContainer<string>();
        container.SetItem("Healing Potion");

        string savedItem = container.GetItem();
        Debug.Log(savedItem);

        string description = GameUtils.DescribeItem(savedItem);
        Debug.Log(description);
    }
}