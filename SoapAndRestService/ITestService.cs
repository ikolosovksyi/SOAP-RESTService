using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace SoapAndRestService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITestService" in both code and config file together.
	[ServiceContract]
	public interface ITestService
	{
		[WebGet]
		[OperationContract]
		string GetStringData();

		[WebGet]
		[OperationContract]
		ComplexType GetComplexData();

		[WebGet]
		[OperationContract]
		List<string> GetSimpleList();

		[WebGet]
		[OperationContract]
		List<ComplexType> GetListOfComplexData();
	}
}
