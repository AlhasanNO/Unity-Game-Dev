using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment26;

public class CreatureManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Kangaroo kangaroo = new();
        Duck duck = new();
        List<Creature> creatures = new() { kangaroo, duck };

        List<IRunnable> runnables = new() { kangaroo, duck };
        List<IJumpable> jumpables = new() { kangaroo };
        List<ISwimable> swimables = new() { duck };

        foreach (var creature in creatures)
        {
            creature.Speak();
        }

        foreach (var creature in runnables)
        {
            creature.Run();
        }

        foreach (var creature in jumpables)
        {
            creature.Jump();
        }

        foreach (var creature in swimables)
        {
            creature.Swim();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
