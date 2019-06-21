using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxObservable
{
	public class DxfController : IDisposable
	{
		private readonly ControllerAccess _ControllerAccess;
		private readonly IDisposable _ControllerStateChangedSubscription;
		private bool isExportingEnable = true;

		public DxfController(ControllerAccess controllerAccess)
		{
			_ControllerAccess = controllerAccess;
			_ControllerStateChangedSubscription = _ControllerAccess.StatusChanged.Subscribe(OnStateChanged);
			Console.WriteLine("DxfController object created\n");
		}

		public void ExportToDxf()
		{
			if (!isExportingEnable)
				Console.WriteLine("\nDXF Exporting is disable\n");
			else
				Console.WriteLine("\nExporting to DXF\n");
		}

		private void OnStateChanged(EventArgs args)
		{
			isExportingEnable = _ControllerAccess.IsControllerStateValid;
			Console.WriteLine("\n*********************** Controller state changed event noticed ***********************\n");
		}

		public void Dispose()
		{
			_ControllerStateChangedSubscription.Dispose();
			isExportingEnable = false;
			Console.WriteLine("\n------------------------Subscription disposed");
		}
	}
}
