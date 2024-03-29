﻿using Exiled.API.Interfaces;
using Exiled.API.Extensions;
using Exiled.API.Enums;
using Exiled.API.Features;
using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Features.Items;
using Exiled.Events.Handlers;
using Item = Exiled.API.Features.Items.Item;

namespace CustomMTFAnnouncement
{
	public class Config : IConfig
	{
		[Description("Whether or not the plugin is enabled.")]
		public bool IsEnabled { get; set; } = true;

		[Description("What should cassie say when there's no scp left.")]
		public string NoscpAnnouncement { get; set; } = "mtfunit epsilon 11 designated {mtfunit} {mtfnum} hasentered allremaining noscpsleft";

        [Description("What should cassie say when there's one scp left.")]
        public string OnescpAnnouncement { get; set; } = "mtfunit epsilon 11 designated {mtfunit} {mtfnum} hasentered allremaining awaitingrecontainment {scpnum} scpsubject";

        [Description("What should cassie say when there are more than 2 scps left.")]
        public string TwoscpsAnnouncement { get; set; } = "mtfunit epsilon 11 designated {mtfunit} {mtfnum} hasentered allremaining awaitingrecontainment {scpnum} scpsubjects";
    }
}
