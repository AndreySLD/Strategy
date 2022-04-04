using Abstractions;
using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

public sealed class Unit : MonoBehaviour, ISelectable
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;

    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private Sprite _icon;

    private float _health = 100;
    public void DrawOutline()
    {
        var outline = gameObject.GetComponent<Outline>();
        outline.enabled = true;
    }
    public void EraseOutline()
    {
        var outline = gameObject.GetComponent<Outline>();
        outline.enabled = false;
    }
}
