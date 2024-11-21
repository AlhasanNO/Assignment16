using assignment18;
using UnityEngine;

public class CharacterTest : MonoBehaviour
{
    void Start()
    {
        Soldier soldier = new Soldier();
        Officer officer = new Officer("Officer", 70, new Position(5, 5, 5));

        Character[] characters = { soldier, officer };

        foreach (Character c in characters)
        {
            c.DisplayInfo();
        }

        Debug.Log($"Before: Soldier Health: {soldier.Health}");

        officer.Attack(30, soldier, "shooting");

        Debug.Log($"After: Soldier Health: {soldier.Health}");
    }
}
