using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSettingsManager.Models
{
	public class SocialLoginSettings
	{
		public bool SocialLoginEnabled { get; set; }
		public KeyValueSettings FacebookSettings { get; set; }
		public KeyValueSettings GoogleSettings { get; set; }
	}
}
