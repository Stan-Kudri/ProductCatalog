using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using VS = System.Windows.Forms.VisualStyles;

namespace ProductCatalog.Controls.CheckComboBoxes
{
    [CLSCompliant(true), ToolboxItem(false)]
    public partial class Popup : ToolStripDropDown
    {
        #region " Fields & Properties "

        private Control _content;
        /// <summary>
        /// Gets the content of the pop-up.
        /// </summary>
        public Control Content
        {
            get { return _content; }
        }

        private bool _fade;
        /// <summary>
        /// Gets a value indicating whether the <see cref="PopupControl.Popup"/> uses the fade effect.
        /// </summary>
        /// <value><c>true</c> if pop-up uses the fade effect; otherwise, <c>false</c>.</value>
        /// <remarks>To use the fade effect, the FocusOnOpen property also has to be set to <c>true</c>.</remarks>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool UseFadeEffect
        {
            get { return _fade; }
            set
            {
                if (_fade == value) return;
                _fade = value;
            }
        }

        private bool _focusOnOpen = true;
        /// <summary>
        /// Gets or sets a value indicating whether to focus the content after the pop-up has been opened.
        /// </summary>
        /// <value><c>true</c> if the content should be focused after the pop-up has been opened; otherwise, <c>false</c>.</value>
        /// <remarks>If the FocusOnOpen property is set to <c>false</c>, then pop-up cannot use the fade effect.</remarks>             
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool FocusOnOpen
        {
            get { return _focusOnOpen; }
            set { _focusOnOpen = value; }
        }

        private bool _acceptAlt = true;
        /// <summary>
        /// Gets or sets a value indicating whether presing the alt key should close the pop-up.
        /// </summary>
        /// <value><c>true</c> if presing the alt key does not close the pop-up; otherwise, <c>false</c>.</value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AcceptAlt
        {
            get { return _acceptAlt; }
            set { _acceptAlt = value; }
        }

        private Popup _ownerPopup;
        private Popup _childPopup;

        private bool _resizable;
        private bool resizable;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="PopupControl.Popup" /> is resizable.
        /// </summary>
        /// <value><c>true</c> if resizable; otherwise, <c>false</c>.</value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Resizable
        {
            get { return resizable && _resizable; }
            set { resizable = value; }
        }

        private readonly ToolStripControlHost _host;

        private Size _minSize;
        /// <summary>
        /// Gets or sets the size that is the lower limit that <see cref="M:System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)" /> can specify.
        /// </summary>
        /// <returns>An ordered pair of type <see cref="T:System.Drawing.Size" /> representing the width and height of a rectangle.</returns>                 
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Size MinimumSize
        {
            get { return _minSize; }
            set { _minSize = value; }
        }

        private Size _maxSize;
        /// <summary>
        /// Gets or sets the size that is the upper limit that <see cref="M:System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)" /> can specify.
        /// </summary>
        /// <returns>An ordered pair of type <see cref="T:System.Drawing.Size" /> representing the width and height of a rectangle.</returns>    
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Size MaximumSize
        {
            get { return _maxSize; }
            set { _maxSize = value; }
        }

        /// <summary>
        /// Gets parameters of a new window.
        /// </summary>
        /// <returns>An object of type <see cref="T:System.Windows.Forms.CreateParams" /> used when creating a new window.</returns>
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= NativeMethods.WS_EX_NOACTIVATE;
                return cp;
            }
        }

        #endregion

        #region " Constructors "

        /// <summary>
        /// Initializes a new instance of the <see cref="PopupControl.Popup"/> class.
        /// </summary>
        /// <param name="content">The content of the pop-up.</param>
        /// <remarks>
        /// Pop-up will be disposed immediately after disposion of the content control.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="content" /> is <code>null</code>.</exception>
        public Popup(Control content)
        {
            ArgumentNullException.ThrowIfNull(content);

            _content = content;
            _fade = SystemInformation.IsMenuAnimationEnabled && SystemInformation.IsMenuFadeEnabled;
            _resizable = true;
            InitializeComponent();
            AutoSize = false;
            DoubleBuffered = true;
            ResizeRedraw = true;
            _host = new ToolStripControlHost(content);
            Padding = Margin = _host.Padding = _host.Margin = Padding.Empty;
            MinimumSize = content.MinimumSize;
            content.MinimumSize = content.Size;
            MaximumSize = content.MaximumSize;
            content.MaximumSize = content.Size;
            Size = content.Size;
            content.Location = Point.Empty;
            Items.Add(_host);
            content.Disposed += delegate (object sender, EventArgs e)
            {
                content = null;
                Dispose(true);
            };
            content.RegionChanged += delegate (object sender, EventArgs e)
            {
                UpdateRegion();
            };
            content.Paint += delegate (object sender, PaintEventArgs e)
            {
                PaintSizeGrip(e);
            };
            UpdateRegion();
        }

        #endregion

        #region " Methods "

        /// <summary>
        /// Processes a dialog box key.
        /// </summary>
        /// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the key to process.</param>
        /// <returns>
        /// true if the key was processed by the control; otherwise, false.
        /// </returns>
        protected override bool ProcessDialogKey(Keys keyData)
            => (!_acceptAlt || (keyData & Keys.Alt) != Keys.Alt) && base.ProcessDialogKey(keyData);

        /// <summary>
        /// Updates the pop-up region.
        /// </summary>
        protected void UpdateRegion()
        {
            if (Region != null)
            {
                Region.Dispose();
                Region = null;
            }
            if (_content.Region != null)
            {
                Region = _content.Region.Clone();
            }
        }

        /// <summary>
        /// Shows pop-up window below the specified control.
        /// </summary>
        /// <param name="control">The control below which the pop-up will be shown.</param>
        /// <remarks>
        /// When there is no space below the specified control, the pop-up control is shown above it.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="control"/> is <code>null</code>.</exception>
        public void Show(Control control)
        {
            ArgumentNullException.ThrowIfNull(control);

            SetOwnerItem(control);
            Show(control, control.ClientRectangle);
        }

        /// <summary>
        /// Shows pop-up window below the specified area of specified control.
        /// </summary>
        /// <param name="control">The control used to compute screen location of specified area.</param>
        /// <param name="area">The area of control below which the pop-up will be shown.</param>
        /// <remarks>
        /// When there is no space below specified area, the pop-up control is shown above it.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="control"/> is <code>null</code>.</exception>
        public void Show(Control control, Rectangle area)
        {
            ArgumentNullException.ThrowIfNull(control);

            SetOwnerItem(control);
            _resizableTop = _resizableRight = false;
            var location = control.PointToScreen(new Point(area.Left, area.Top + area.Height));
            var screen = Screen.FromControl(control).WorkingArea;

            if (location.X + Size.Width > (screen.Left + screen.Width))
            {
                _resizableRight = true;
                location.X = (screen.Left + screen.Width) - Size.Width;
            }

            if (location.Y + Size.Height > (screen.Top + screen.Height))
            {
                _resizableTop = true;
                location.Y -= Size.Height + area.Height;
            }

            location = control.PointToClient(location);
            Show(control, location, ToolStripDropDownDirection.BelowRight);
        }

        private const int Frames = 1;
        private const int Totalduration = 0; // ML : 2007-11-05 : was 100 but caused a flicker.
        private const int Frameduration = Totalduration / Frames;

        /// <summary>
        /// Adjusts the size of the owner <see cref="T:System.Windows.Forms.ToolStrip" /> to accommodate the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> if the owner <see cref="T:System.Windows.Forms.ToolStrip" /> is currently displayed, or clears and resets active <see cref="T:System.Windows.Forms.ToolStripDropDown" /> child controls of the <see cref="T:System.Windows.Forms.ToolStrip" /> if the <see cref="T:System.Windows.Forms.ToolStrip" /> is not currently displayed.
        /// </summary>
        /// <param name="visible">true if the owner <see cref="T:System.Windows.Forms.ToolStrip" /> is currently displayed; otherwise, false.</param>
        protected override void SetVisibleCore(bool visible)
        {
            var opacity = Opacity;
            if (visible && _fade && _focusOnOpen) Opacity = 0;
            base.SetVisibleCore(visible);
            if (!visible || !_fade || !_focusOnOpen) return;
            for (var i = 1; i <= Frames; i++)
            {
                if (i > 1)
                {
                    System.Threading.Thread.Sleep(Frameduration);
                }
                Opacity = opacity * i / Frames;
            }
            Opacity = opacity;
        }

        private bool _resizableTop;
        private bool _resizableRight;

        private void SetOwnerItem(Control control)
        {
            if (control == null)
            {
                return;
            }

            if (control is Popup)
            {
                var popupControl = control as Popup;
                _ownerPopup = popupControl;
                _ownerPopup._childPopup = this;
                OwnerItem = popupControl.Items[0];
                return;
            }

            if (control.Parent != null)
            {
                SetOwnerItem(control.Parent);
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.SizeChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnSizeChanged(EventArgs e)
        {
            _content.MinimumSize = Size;
            _content.MaximumSize = Size;
            _content.Size = Size;
            _content.Location = Point.Empty;
            base.OnSizeChanged(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ToolStripDropDown.Opening" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.ComponentModel.CancelEventArgs" /> that contains the event data.</param>
        protected override void OnOpening(CancelEventArgs e)
        {
            if (_content.IsDisposed || _content.Disposing)
            {
                e.Cancel = true;
                return;
            }

            UpdateRegion();
            base.OnOpening(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ToolStripDropDown.Opened" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnOpened(EventArgs e)
        {
            if (_ownerPopup != null)
            {
                _ownerPopup._resizable = false;
            }

            if (_focusOnOpen)
            {
                _content.Focus();
            }

            base.OnOpened(e);
        }

        protected override void OnClosed(ToolStripDropDownClosedEventArgs e)
        {
            if (_ownerPopup != null)
            {
                _ownerPopup._resizable = true;
            }

            base.OnClosed(e);
        }

        public DateTime LastClosedTimeStamp = DateTime.Now;

        protected override void OnVisibleChanged(EventArgs e)
        {
            if (!Visible)
            {
                LastClosedTimeStamp = DateTime.Now;
            }

            base.OnVisibleChanged(e);
        }

        #endregion

        #region " Resizing Support "

        /// <summary>
        /// Processes Windows messages.
        /// </summary>
        /// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
        protected override void WndProc(ref Message m)
        {
            if (InternalProcessResizing(ref m, false))
            {
                return;
            }

            base.WndProc(ref m);
        }

        /// <summary>
        /// Processes the resizing messages.
        /// </summary>
        /// <param name="m">The message.</param>
        /// <returns>true, if the WndProc method from the base class shouldn't be invoked.</returns>
        public bool ProcessResizing(ref Message m)
        {
            return InternalProcessResizing(ref m, true);
        }

        private bool InternalProcessResizing(ref Message m, bool contentControl)
        {
            if (m.Msg == NativeMethods.WM_NCACTIVATE && m.WParam != IntPtr.Zero && _childPopup != null && _childPopup.Visible)
            {
                _childPopup.Hide();
            }

            if (!Resizable)
            {
                return false;
            }

            if (m.Msg == NativeMethods.WM_NCHITTEST)
            {
                return OnNcHitTest(ref m, contentControl);
            }

            else if (m.Msg == NativeMethods.WM_GETMINMAXINFO)
            {
                return OnGetMinMaxInfo(ref m);
            }

            return false;
        }

        private bool OnGetMinMaxInfo(ref Message m)
        {
            var minmax = Marshal.PtrToStructure<NativeMethods.MINMAXINFO>(m.LParam);
            minmax.maxTrackSize = MaximumSize;
            minmax.minTrackSize = MinimumSize;
            Marshal.StructureToPtr(minmax, m.LParam, false);
            return true;
        }

        private bool OnNcHitTest(ref Message m, bool contentControl)
        {
            var x = NativeMethods.LOWORD(m.LParam);
            var y = NativeMethods.HIWORD(m.LParam);
            var clientLocation = PointToClient(new Point(x, y));

            var gripBouns = new GripBounds(contentControl ? _content.ClientRectangle : ClientRectangle);
            var transparent = new IntPtr(NativeMethods.HTTRANSPARENT);

            if (_resizableTop)
            {
                if (_resizableRight && gripBouns.TopLeft.Contains(clientLocation))
                {
                    m.Result = contentControl ? transparent : NativeMethods.HTTOPLEFT;
                    return true;
                }

                if (!_resizableRight && gripBouns.TopRight.Contains(clientLocation))
                {
                    m.Result = contentControl ? transparent : NativeMethods.HTTOPRIGHT;
                    return true;
                }

                if (gripBouns.Top.Contains(clientLocation))
                {
                    m.Result = contentControl ? transparent : NativeMethods.HTTOP;
                    return true;
                }
            }
            else
            {
                if (_resizableRight && gripBouns.BottomLeft.Contains(clientLocation))
                {
                    m.Result = contentControl ? transparent : NativeMethods.HTBOTTOMLEFT;
                    return true;
                }
                if (!_resizableRight && gripBouns.BottomRight.Contains(clientLocation))
                {
                    m.Result = contentControl ? transparent : NativeMethods.HTBOTTOMRIGHT;
                    return true;
                }
                if (gripBouns.Bottom.Contains(clientLocation))
                {
                    m.Result = contentControl ? transparent : NativeMethods.HTBOTTOM;
                    return true;
                }
            }

            if (_resizableRight && gripBouns.Left.Contains(clientLocation))
            {
                m.Result = contentControl ? transparent : NativeMethods.HTLEFT;
                return true;
            }

            if (!_resizableRight && gripBouns.Right.Contains(clientLocation))
            {
                m.Result = contentControl ? transparent : NativeMethods.HTRIGHT;
                return true;
            }

            return false;
        }

        private VS.VisualStyleRenderer _sizeGripRenderer;
        /// <summary>
        /// Paints the size grip.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs" /> instance containing the event data.</param>
        public void PaintSizeGrip(PaintEventArgs e)
        {
            if (e == null || e.Graphics == null || !resizable)
            {
                return;
            }
            var clientSize = _content.ClientSize;
            if (Application.RenderWithVisualStyles)
            {
                _sizeGripRenderer ??= new VS.VisualStyleRenderer(VS.VisualStyleElement.Status.Gripper.Normal);
                _sizeGripRenderer.DrawBackground(e.Graphics, new Rectangle(clientSize.Width - 0x10, clientSize.Height - 0x10, 0x10, 0x10));
            }
            else
            {
                ControlPaint.DrawSizeGrip(e.Graphics, _content.BackColor, clientSize.Width - 0x10, clientSize.Height - 0x10, 0x10, 0x10);
            }
        }
        #endregion
    }
}
