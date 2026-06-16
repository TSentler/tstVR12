using UnityEngine;

public class InteractButton : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "RedButton")
        {
           print("есть контакт");
           FindAnyObjectByType<PotionSystem>().BrewPotion();
        }
    }
}
