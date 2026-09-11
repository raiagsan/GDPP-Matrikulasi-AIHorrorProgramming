using Unity.VisualScripting;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] private PlayerCharacter _owner;
    [SerializeField] private Light _light;

    public bool HasFlashlight => _owner.Inventory.CheckItem("FLASHLIGHT_001");

    public void UseFlashlight()
    {
        if (HasFlashlight == true && _light != null)
        {
            _light.enabled = !_light.enabled;
        }
    }
}
