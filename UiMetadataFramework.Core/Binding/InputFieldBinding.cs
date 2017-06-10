namespace UiMetadataFramework.Core.Binding
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Represents a binding between a <see cref="Type"/> of field and the client-side
	/// control which will render that field. The binding can involve multiple server-side
	/// types being bound to the same client-side control.
	/// </summary>
	public class InputFieldBinding
	{
		public InputFieldBinding(Type serverType, string clientType)
		{
			this.ServerTypes = new[] { serverType };
			this.ClientType = clientType;
		}

		public InputFieldBinding(IEnumerable<Type> serverTypes, string clientType)
		{
			this.ServerTypes = serverTypes;
			this.ClientType = clientType;
		}

		/// <summary>
		/// Gets name of the client control which will render the output field.
		/// </summary>
		public string ClientType { get; }

		/// <summary>
		/// Gets the server-side types being bound.
		/// </summary>
		public IEnumerable<Type> ServerTypes { get; set; }

		/// <summary>
		/// Gets custom properties of the input field.
		/// </summary>
		/// <param name="attribute"><see cref="InputFieldAttribute"/> which was applied to the input field.</param>
		/// <returns>Object representing custom properties for the input field or null if there are none.</returns>
		public virtual object GetCustomProperties(InputFieldAttribute attribute)
		{
			return null;
		}
	}
}