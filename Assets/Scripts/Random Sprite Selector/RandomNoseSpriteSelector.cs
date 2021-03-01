using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNoseSpriteSelector : MonoBehaviour
{
    [SerializeField] Sprite[] eyes_SpritesArray;
    void Start()
    {
        SelectNewNoseSprite();
    }

    // Update is called once per frame
    public void SelectNewNoseSprite()
    {
        GetComponent<SpriteRenderer>().sprite = eyes_SpritesArray[Random.Range(0, eyes_SpritesArray.Length)];
    }
}
