using System;
using Eto.Forms;
using Eto.Drawing;

namespace SourceGrid.Cells.Controllers
{
	/// <summary>
	/// In this Controller are defined all the events fired by the Controller. Each event has a sender object of type CellContext that you can use to read the cell informations.
	/// </summary>
	public class CustomEvents : IController
	{
		#region IController Members

		public event EventHandler MouseDown;
		public void OnMouseDown(CellContext sender, MouseEventArgs e)
		{
			if (MouseDown!=null)
				MouseDown(sender, e);
		}

		public event EventHandler MouseUp;
		public void OnMouseUp(CellContext sender, MouseEventArgs e)
		{
			if (MouseUp!=null)
				MouseUp(sender, e);
		}

		public event EventHandler MouseMove;
		public void OnMouseMove(CellContext sender, MouseEventArgs e)
		{
			if (MouseMove!=null)
				MouseMove(sender, e);
		}
#if !MINI
		public event EventHandler MouseEnter;
		public void OnMouseEnter(CellContext sender, EventArgs e)
		{
			if (MouseEnter!=null)
				MouseEnter(sender, e);
		}

		public event EventHandler MouseLeave;
		public void OnMouseLeave(CellContext sender, EventArgs e)
		{
			if (MouseLeave!=null)
				MouseLeave(sender, e);
		}
#endif

		public event EventHandler KeyUp;
		public void OnKeyUp(CellContext sender, KeyEventArgs e)
		{
			if (KeyUp!=null)
				KeyUp(sender, e);
		}

		public event EventHandler KeyDown;
		public void OnKeyDown(CellContext sender, KeyEventArgs e)
		{
			if (KeyDown!=null)
				KeyDown(sender, e);
		}

		public event EventHandler KeyPress;
		public void OnKeyPress(CellContext sender, KeyEventArgs e)
		{
			if (KeyPress!=null)
				KeyPress(sender, e);
		}

#if !MINI
		public event EventHandler DoubleClick;
		public void OnDoubleClick(CellContext sender, EventArgs e)
		{
			if (DoubleClick!=null)
				DoubleClick(sender, e);
		}
#endif

		public event EventHandler Click;
		public void OnClick(CellContext sender, EventArgs e)
		{
			if (Click!=null)
				Click(sender, e);
		}

		public event System.ComponentModel.CancelEventHandler FocusLeaving;
		public void OnFocusLeaving(CellContext sender, System.ComponentModel.CancelEventArgs e)
		{
			if (FocusLeaving!=null)
				FocusLeaving(sender, e);
		}
		public event EventHandler FocusLeft;
		public void OnFocusLeft(CellContext sender, EventArgs e)
		{
			if (FocusLeft!=null)
				FocusLeft(sender, e);
		}

		public event System.ComponentModel.CancelEventHandler FocusEntering;
		public void OnFocusEntering(CellContext sender, System.ComponentModel.CancelEventArgs e)
		{
			if (FocusEntering!=null)
				FocusEntering(sender, e);
		}
		public event EventHandler FocusEntered;
		public void OnFocusEntered(CellContext sender, EventArgs e)
		{
			if (FocusEntered!=null)
				FocusEntered(sender, e);
		}


		/// <summary>
		/// Fired before the value of the cell is changed.
		/// </summary>
        public event ValueChangeEventHandler ValueChanging;
		/// <summary>
		/// Fired before the value of the cell is changed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void OnValueChanging(CellContext sender, ValueChangeEventArgs e)
		{
			if (ValueChanging!=null)
				ValueChanging(sender, e);
		}

		/// <summary>
		/// Fired after the value of the cell is changed.
		/// </summary>
		public event EventHandler ValueChanged;
		/// <summary>
		/// Fired after the value of the cell is changed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void OnValueChanged(CellContext sender, EventArgs e)
		{
			if (ValueChanged!=null)
				ValueChanged(sender, e);
		}

		public event System.ComponentModel.CancelEventHandler EditStarting;
		public virtual void OnEditStarting(CellContext sender, System.ComponentModel.CancelEventArgs e)
		{
			if (EditStarting!=null)
				EditStarting(sender, e);
		}
		public event System.EventHandler EditStarted;
		public virtual void OnEditStarted(CellContext sender, System.EventArgs e)
		{
			if (EditStarted!=null)
				EditStarted(sender, e);
		}
		public event System.EventHandler EditEnded;
		public virtual void OnEditEnded(CellContext sender, System.EventArgs e)
		{
			if (EditEnded!=null)
				EditEnded(sender, e);
		}

		public virtual bool CanReceiveFocus(CellContext sender, EventArgs e)
		{
			return true;
		}


		public event EventHandler DragDrop;
		public virtual void OnDragDrop(CellContext sender, DragEventArgs e)
		{
			if (DragDrop!=null)
				DragDrop(sender, e);
		}
		public event EventHandler DragEnter;
		public virtual void OnDragEnter(CellContext sender, DragEventArgs e)
		{
			if (DragEnter!=null)
				DragEnter(sender, e);
		}
		public event EventHandler DragLeave;
		public virtual void OnDragLeave(CellContext sender, EventArgs e)
		{
			if (DragLeave!=null)
				DragLeave(sender, e);
		}
		public event EventHandler DragOver;
		public virtual void OnDragOver(CellContext sender, DragEventArgs e)
		{
			if (DragOver!=null)
				DragOver(sender, e);
		}
		public event EventHandler GiveFeedback;
		public void OnGiveFeedback(CellContext sender, EventHandler e)
		{
			if (GiveFeedback != null)
				GiveFeedback(sender, e);
		}
		#endregion
	}
}
