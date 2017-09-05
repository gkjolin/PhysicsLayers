﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace a3geek.PhysicsLayers.Examples
{
    using System;
    using Abstracts;

    [AddComponentMenu("")]
    public class CollisionTest : AbstractCollisionTest<Rigidbody>
    {
        protected override Vector3 GetVelocity()
        {
            return this.rigid.velocity;
        }

        protected override void SetVelocity(Vector3 velocity)
        {
            this.rigid.velocity = velocity;
        }
    }
}
