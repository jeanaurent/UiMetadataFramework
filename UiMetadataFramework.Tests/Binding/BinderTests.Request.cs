namespace UiMetadataFramework.Tests.Binding
{
	using System;
	using UiMetadataFramework.Basic.Input;
	using UiMetadataFramework.Core.Binding;

	public partial class BinderTests
	{
		public class Request
		{
			[Option("Low", "L")]
			[Option("Mid", "M")]
			[Option("High", "H")]
			public DropdownValue<string> Category { get; set; }

			[InputField(Label = "DoB", OrderIndex = 2)]
			public DateTime DateOfBirth { get; set; }

			public DropdownValue<DayOfWeek?> Day { get; set; }

			[Option(DayOfWeek.Sunday)]
			[Option(DayOfWeek.Monday)]
			public DropdownValue<DayOfWeek> FirstDayOfWeek { get; set; }

			[InputField(Label = "First name", OrderIndex = 1, Required = true)]
			public string FirstName { get; set; }

			[InputField(Hidden = true)]
			public int? Height { get; set; }

			public bool IsRegistered { get; set; }

			public DateTime? SubmissionDate { get; set; }

			[InputField(Hidden = true)]
			[InputFieldEventHandler]
			public decimal Weight { get; set; }
		}
	}
}