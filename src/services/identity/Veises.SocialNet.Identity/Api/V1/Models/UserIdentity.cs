﻿using System.ComponentModel.DataAnnotations;

namespace Veises.SocialNet.Identity.Api.V1.Models
{
	/// <summary>
	/// User identity model
	/// </summary>
	public sealed class UserIdentity
	{
		/// <summary>
		/// User display name
		/// </summary>
		[Required]
		public string UserName { get; set; }
	}
}