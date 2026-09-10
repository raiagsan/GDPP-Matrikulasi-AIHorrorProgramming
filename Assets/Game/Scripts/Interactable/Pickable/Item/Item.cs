using UnityEngine;

public class Item : MonoBehaviour, IInteractable, IPicakble
{
    [SerializeField] private ItemData _itemData;

    public string Name => _itemData.Name;

    public void Interact()
    {
        Pickup();
    }

    public void Pickup()
    {
        
    }
    
}
