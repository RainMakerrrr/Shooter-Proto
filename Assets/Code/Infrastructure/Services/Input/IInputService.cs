using System;
using UnityEngine;

namespace Code.Infrastructure.Services.Input
{
    public interface IInputService
    {
        event Action ShootLeftClicked;
        event Action ShootRightClicked;
        event Action EquipLeftClicked;
        event Action EquipRightClicked;
        event Action ResetClicked;
        Vector2 MovementInput { get; }
        Vector2 CameraRotationInput { get; }
    }
}