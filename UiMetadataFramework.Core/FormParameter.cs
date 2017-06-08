﻿namespace UiMetadataFramework.Core
{
	/// <summary>
	/// Indicates where to get value for a certain form request parameter.
	/// </summary>
	public class FormParameter
	{
		/// <summary>
		/// Initializes a new instance of <see cref="FormParameter"/> class.
		/// </summary>
		/// <param name="parameter">Name of the request parameter.</param>
		/// <param name="property">Name of the property from which to get the value for the <see cref="Parameter"/>.</param>
		public FormParameter(
			string parameter,
			string property)
		{
			this.Property = property;
			this.Parameter = parameter;
		}

		/// <summary>
		/// Name of the request parameter.
		/// </summary>
		public string Parameter { get; }

		/// <summary>
		/// Name of the property form which to get value for the <see cref="Parameter"/>.
		/// </summary>
		public string Property { get; }
	}
}