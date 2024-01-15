using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomizationUI : MonoBehaviour
{
    //creates a private instance
    [SerializeField] private Button Hair,Head,Shirt,Pants,Shoe;//buttons for Male
    [SerializeField] private PlayerChracterCustomized playerCharacterCustomized;//playerMaleScript

    private void Awake()
    {
        //Button Indication
        Hair.onClick.AddListener(() => {
            //Debug.Log("HairLiam");
            playerCharacterCustomized.ChangeBodyPart(PlayerChracterCustomized.BodyPartType.HairLiam);
        });
        Head.onClick.AddListener(() => {
            //Debug.Log("Head");
            playerCharacterCustomized.ChangeBodyPart(PlayerChracterCustomized.BodyPartType.Head);
        });
        Shirt.onClick.AddListener(() => {
            //Debug.Log("Shirt");
            playerCharacterCustomized.ChangeBodyPart(PlayerChracterCustomized.BodyPartType.Shirt);
        });
        Pants.onClick.AddListener(() => {
            //Debug.Log("pants");
            playerCharacterCustomized.ChangeBodyPart(PlayerChracterCustomized.BodyPartType.Pants);
        });
        Shoe.onClick.AddListener(() => {
            //Debug.Log("Feet");
            playerCharacterCustomized.ChangeBodyPart(PlayerChracterCustomized.BodyPartType.Feet);
        });
    }

}
