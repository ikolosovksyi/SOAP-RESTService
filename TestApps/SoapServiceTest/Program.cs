using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using SoapServiceTest.TestServiceReference;

namespace SoapServiceTest
{
	class Program
	{
		static void Main(string[] args)
		{
			
			TestServiceClient client = new TestServiceClient();
			string stringData = client.GetStringData();
			string[] stringsList = client.GetSimpleList();
			ComplexType complexData = client.GetComplexData();
			ComplexType[] listOfComplexData = client.GetListOfComplexData();

			JavaScriptSerializer serializer = new JavaScriptSerializer();

			Console.WriteLine("Note: all data serialized from objects to JSON for better clarity");
			Console.WriteLine("String data:   {0}", stringData);
			Console.WriteLine();
			Console.WriteLine("Strings list:  {0}", serializer.Serialize(stringsList));
			Console.WriteLine();
			Console.WriteLine("Complex type:  {0}", serializer.Serialize(complexData));
			Console.WriteLine();
			Console.WriteLine("Complex types: {0}", serializer.Serialize(listOfComplexData));

			Console.ReadLine();
		}
	}
}
