using System.Runtime.Serialization;

namespace SoapAndRestService
{
	[DataContract]
	public class ComplexType : IExtensibleDataObject 
	{
		[DataMember]
		public string SimpleField { get; set; }
		
		public ExtensionDataObject ExtensionData { get; set; }
	}
}