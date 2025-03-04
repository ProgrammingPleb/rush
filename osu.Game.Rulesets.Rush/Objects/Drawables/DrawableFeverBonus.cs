// Copyright (c) Shane Woolcock. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using osu.Game.Rulesets.Judgements;

namespace osu.Game.Rulesets.Rush.Objects.Drawables
{
    public partial class DrawableFeverBonus : DrawableRushHitObject<FeverBonus>
    {
        public override bool DisplayExplosion => false;
        public override bool DisplayResult => false;

        public DrawableFeverBonus()
            : this(null)
        {
        }

        public DrawableFeverBonus(FeverBonus hitObject)
            : base(hitObject)
        {
        }

        public new void ApplyResult(Action<JudgementResult> application)
        {
            if (!Result.HasResult)
                base.ApplyResult(application);
        }

        protected override void CheckForResult(bool userTriggered, double timeOffset)
        {
        }
    }
}
