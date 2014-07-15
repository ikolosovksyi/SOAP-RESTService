using System.Linq;

namespace SoapAndRestService
{
	using System.Collections.Generic;

	public class TestService : ITestService
	{
		#region Public methods

		public string GetStringData()
		{
			return string.Join(" ", StringFakeData());
		}

		public ComplexType GetComplexData()
		{
			return ComplexTypeFakeData().First();
		}

		public List<string> GetSimpleList()
		{
			return StringFakeData();
		}

		public List<ComplexType> GetListOfComplexData()
		{
			return ComplexTypeFakeData().ToList();
		}

		#endregion Public methods

		#region Private methods

		private List<string> StringFakeData()
		{
			return new List<string>
			{
				"Hi",
				"there.",
				"It's",
				"a",
				"string"
			};
		}

		private IEnumerable<ComplexType> ComplexTypeFakeData()
		{
			List<string> stringsList = StringFakeData();

			return stringsList.Select(str => new ComplexType() {SimpleField = str});
		}

		#endregion Private methods
	}
}
