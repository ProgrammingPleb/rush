// Copyright (c) Shane Woolcock. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Game.Overlays.Settings;
using osu.Game.Rulesets.Rush.Configuration;

namespace osu.Game.Rulesets.Rush.UI
{
    public class RushSettingsSubsection : RulesetSettingsSubsection
    {
        protected override string Header => RushRuleset.IsDevelopmentBuild ? "rush (Dev build)" : "rush";

        public RushSettingsSubsection(Ruleset ruleset)
            : base(ruleset)
        {
        }

        [BackgroundDependencyLoader]
        private void load()
        {
            var config = (RushRulesetConfigManager)Config;

            // for an odd reason, Config seems to be passed as null when creating it. doesnt even get called...
            if (config == null)
                return;

            Children = new Drawable[]
            {
                new SettingsCheckbox
                {
                    LabelText = "Automatic Fever activation",
                    Current = config.GetBindable<bool>(RushRulsetSettings.AutomaticFever)
                },
            };
        }
    }
}
