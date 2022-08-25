using System;
using Code.Logic.Weapons;
using UnityEngine;

namespace Code.Logic.Player.Pickup
{
    public class WeaponSlot : MonoBehaviour
    {
        [SerializeField] private Transform _weaponPosition;

        public BaseWeapon Weapon { get; private set; }

        public bool HasWeapon => Weapon != null;

        public void TryAttachWeapon(BaseWeapon weapon)
        {
            if (HasWeapon)
            {
                if (Weapon == weapon)
                {
                    DetachWeapon();
                }
                else
                {
                    DetachWeapon();
                    AttachWeapon(weapon);
                }
            }
            else
            {
                AttachWeapon(weapon);
            }
        }

        public void AttachWeapon(BaseWeapon weapon)
        {
            Weapon = weapon;
            Weapon.SetPosition(transform, _weaponPosition.position);
            Weapon.DisableCollider();
        }

        public void DetachWeapon()
        {
            Weapon.ReturnStartPosition();
            Weapon.EnableCollider();
            Weapon = null;
        }
    }
}