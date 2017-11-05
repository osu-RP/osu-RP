﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Game.Configuration;
using osu.Game.Overlays.Settings;

namespace osu.Game.Rulesets.Karaoke.UI
{
    public class KaraokeSettings : SettingsSubsection
    {
        protected override string Header => "osu!";

        [BackgroundDependencyLoader]
        private void load(OsuConfigManager config)
        {
            Children = new Drawable[]
            {
                new SettingsCheckbox
                {
                    LabelText = "Show Translate by google",
                    //Bindable = config.GetBindable<bool>(OsuSetting.SnakingInSliders)
                },
                new SettingsCheckbox
                {
                    LabelText = "Always shows the karaoke panel",
                    //Bindable = config.GetBindable<bool>(OsuSetting.SnakingOutSliders)
                },
                new SettingsCheckbox
                {
                    LabelText = "Karaoke Effect",
                    //Bindable = config.GetBindable<bool>(OsuSetting.SnakingOutSliders)
                },
                new SettingsCheckbox
                {
                    LabelText = "Enable HotKey",
                    //Bindable = config.GetBindable<bool>(OsuSetting.SnakingOutSliders)
                },
            };
        }
    }
}