using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxObservable
{
	public class ControllerAccess
	{
		public event EventHandler StateChanged;
		private bool _isControllerStateValid = true;
		public bool IsControllerStateValid
		{
			get { return _isControllerStateValid; }
			set
			{
				if (_isControllerStateValid != value)
				{
					_isControllerStateValid = value;
				}
			}
		}
		
		public void RaiseEventToChangeControllerState()
		{
			OnStateChanged(EventArgs.Empty);
		}

		protected virtual void OnStateChanged(EventArgs e)
		{
			EventHandler handler = StateChanged;
			if (handler != null)
			{
				ChangeControllerState();
				handler(this, e);
			}
		}

		private void ChangeControllerState()
		{
			IsControllerStateValid = !IsControllerStateValid;
		}

		public IObservable<EventArgs> StatusChanged
		{
			get
			{
				return Observable.FromEventPattern<EventHandler, EventArgs>(
						handler => StateChanged += handler,
						handler => StateChanged -= handler)
						.Select(pattern => pattern.EventArgs);
			}
		}
	}
}
