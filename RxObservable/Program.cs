using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RxObservable
{
	class Program
	{
		static void Main(string[] args)
		{
			ControllerAccess controllerAccess = new ControllerAccess();
			DxfController dxfController = new DxfController(controllerAccess);
			Console.WriteLine("press 'e' to export or 'c' to change the controller state and 'd' to dispose\n");

			while (true)
			{
				char input = Console.ReadKey().KeyChar;
				if (input== 'e')
					dxfController.ExportToDxf();
				else if (input == 'c')
					controllerAccess.RaiseEventToChangeControllerState();
				else if (input == 'd')
					dxfController.Dispose();
			}

			Console.ReadKey();
		}
	}
}
