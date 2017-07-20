﻿namespace UiMetadataFramework.Core
{
	/// <summary>
	/// Metadata describing how to handle the response.
	/// </summary>
	public class FormResponseMetadata
	{
		public FormResponseMetadata()
		{
		}

		public FormResponseMetadata(string handler)
		{
			this.Handler = handler;
		}

		/// <summary>
		/// Gets or sets name of the client-side handler which will be responsible for
		/// processing the <see cref="FormResponse{T}"/>.
		/// </summary>
		/// <remarks>Client can implement an arbitrary number of handlers,
		/// however usually it will at least need to have an "object" handler,
		/// which will simply render the response. Other handlers might include "redirect" handler,
		/// which will redirect to another form or URL.</remarks>
		public string Handler { get; internal set; }
	}
}