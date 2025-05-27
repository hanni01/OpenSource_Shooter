﻿using UnityEngine;
public class WeaponAnim_ShotGun : AnimationHandler
{
    [TextArea(2, 10)]
    public string notes = "This class has methods to handle the animations of the derived class W_ShootProjectileCanCharge.";

    public enum Animation { Idle, BasicShot, StrongShot }

    public void PlayAnimation(Animation name)
    {
        switch (name)
        {
            case Animation.Idle:
                PlayAnimation("Idle");
                break;

            case Animation.BasicShot:
                PlayAnimation("BasicShot");
                break;
            
            case Animation.StrongShot:
                PlayAnimation("StrongShot");
                break;

            default:
                break;
        }
    }

    public new void SetAnimationSpeed(string name, float speed)
    {
        base.SetAnimationSpeed(name, speed);
    }
}
