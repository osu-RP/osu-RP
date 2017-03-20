﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System.Collections.Generic;
using osu.Game.Modes.Judgements;
using osu.Game.Modes.RP.Objects.Drawables;
using OpenTK;

namespace osu.Game.Modes.RP.ScoreProcessor
{
    public class RPJudgementInfo :  JudgementInfo
    {
        public RPScoreResult Score;
        public List<Vector2> HitExplosionPosition = new List<Vector2>();
        public int additionalPlusScore = 0;

    }
}