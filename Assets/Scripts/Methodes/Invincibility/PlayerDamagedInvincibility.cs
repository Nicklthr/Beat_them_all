using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamagedInvincibility : MonoBehaviour
{
    [SerializeField]
    private float _invincibilityDuration;

    [SerializeField]
    private Color _flashColor;

    [SerializeField]
    private int _numberOfFlashes;

    private InvincibilityManager _invincibilityController;

    private void Awake()
    {
        _invincibilityController = GetComponent<InvincibilityManager>();
    }
    public void StartInvincibility()
    {
        Debug.Log("PlayerDamagedInvincibility.StartInvincibility()");
        _invincibilityController.StartInvincibility(_invincibilityDuration, _flashColor, _numberOfFlashes);
    }
}
