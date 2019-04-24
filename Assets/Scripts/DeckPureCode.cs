using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckPureCode : MonoBehaviour
{

    // I added a sprite and split it using the sprite editor
    // Set "Sprite Mode" to Multiple
    // Open Sprite Editor and split using rows/cols
    // More help here https://docs.unity3d.com/Manual/SpriteEditor.html
    // Full deck image came from here: http://www.milefoot.com/math/discrete/counting/images/cards.png
    // Start is called before the first frame update
    void Start()
    {
        //Get the sliced card images as an array of 52 sprites
        Sprite[] cardSprites = Resources.LoadAll<Sprite>("Sprites/cards");
        
        for (int i = 0; i < 52; i++)
        {         
            //Create the cardInstance
            GameObject cardInstance = new GameObject("Card" + i);
            //this makes the cardInstance a chile of the "Interface" game object in the unity interface (it's optional)
            cardInstance.transform.parent = this.transform;
            
            //The Sprite Renderer is necessary to show the card sprite
            SpriteRenderer spriteRenderer = cardInstance.AddComponent<SpriteRenderer>();
            //Set the sprite for our card instance sprite renderer
            spriteRenderer.sprite = cardSprites[i];
            
            //the cards are really small so I scaled them 4x
            float myScale = 4f;
            spriteRenderer.transform.localScale = new Vector3(myScale, myScale, myScale);
            //position the cards on the screen

            cardInstance.transform.position = new Vector3( .4f * i - 10, 0f, 0f);
            
            //This debug message will show up in the console in Unity
            Debug.Log("Created Instance " + i);
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
