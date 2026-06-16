using System.Collections.Generic;
using UnityEngine;

public class PotionSystem : MonoBehaviour
{
    public PotionSpavner spawner; 
    public Claudron cauldron;

    public GameObject water;
    public GameObject kost;

    public void BrewPotion()
    {
        List<IngredientType> ingredients = cauldron.currentIngredients;
        // vision potion
        if (ingredients.Contains(IngredientType.Mushroom) &&
            ingredients.Contains(IngredientType.Kost) &&
            ingredients.Count == 2)
        {
            Debug.Log("Vision potion worked!");
            spawner.Spawn(water);
        }
        else if (ingredients.Contains(IngredientType.Water) &&
            ingredients.Contains(IngredientType.Watermelon) &&
            ingredients.Count == 2)
        {
            Debug.Log("zele strong gotovo!");
            spawner.Spawn(kost);
                
        }
        cauldron.ClearCauldron();
    }
}
