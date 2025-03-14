using UnityEditor;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField]
    private FruitType _type;

    [SerializeField]
    private int _score;

    public enum FruitType
    {

        Cherry,
        Strawberry,
        Raspberry,
        Orange,
        Apple,
        Apricot,
        Grapefruit,
        HoneydewMelon,
        WaterMelon
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //dropper.currentFruit = null;
        //dropper.SpawnNewFruit();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //isTouchingTopBar = true;
        //StartCoroutine(WaitForEndGame());
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //isTouchingTopBar = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // gets fruit component on the other fruit
        Fruit otherFruit = collision.gameObject.GetComponent<Fruit>();
        if (otherFruit != null && otherFruit._type == _type && gameObject.GetInstanceID() < collision.gameObject.GetInstanceID())
        {
            //game.InstantiateFruit(this.transform.position, this.id + 1);
            //game.addScore(this.id);
            //StartCoroutine(DestroyFruits(this.gameObject, collision.gameObject));
        }
    }
}