using System;

namespace RxObservable
{
	public class CMMController
	{
		public event EventHandler StateChanged;

		protected virtual void OnThresholdReached(EventArgs e)
		{
			EventHandler handler = StateChanged;
			if (handler != null)
			{
				handler(this, e);
			}
		}
	}
}