using UnityEngine;

public class HidingCloset : MonoBehaviour, IInteractable
{
    [SerializeField] private string _name;
    [SerializeField] private Transform _hidePosition;
    [SerializeField] private Transform _unhidePosition;
    [SerializeField] private float _duration = 1f;
    [SerializeField] private Door _door;

    private PlayerCharacter _hidingPlayer;
    public string Name => _name;

    public void Interact(PlayerCharacter character)
    {
        
    }
}
