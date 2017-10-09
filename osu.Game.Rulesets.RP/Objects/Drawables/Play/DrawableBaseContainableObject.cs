﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System.Collections.Generic;
using System.Linq;
using osu.Game.Rulesets.RP.Judgements;
using osu.Game.Rulesets.RP.Objects.Drawables.Interface;

namespace osu.Game.Rulesets.RP.Objects.Drawables.Play
{
    /// <summary>
    /// Base object that can acceppt another object drag onto it
    /// </summary>
    public abstract class DrawableBaseContainableObject<T> : DrawableBaseRpObject, ICanContainObject
    {
        //FadeInTime
        public override float FadeInTime => 300;

        //FadeOutTime
        public override float FadeOutTime => 300;

        public DrawableBaseContainableObject(BaseRpObject hitObject)
            : base(hitObject)
        {
        }
    }
}
