using UnityEngine;

public class KPellet : Pellet
{
    public float duration = 8f;

    protected override void Eat()
    {
        FindObjectOfType<GameManager>().KPelletEaten(this);
    }

}
