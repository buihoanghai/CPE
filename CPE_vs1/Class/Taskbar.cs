using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class Taskbar
{
    [DllImport("user32.dll")]
    private static extern int FindWindow(string className, string windowText);

    [DllImport("user32.dll")]
    private static extern int ShowWindow(int hwnd, int command);

    [DllImport("user32.dll")]
    public static extern int FindWindowEx(int parentHandle, int childAfter, string className, int windowTitle);

    [DllImport("user32.dll")]
    private static extern int GetDesktopWindow();

    private const int SW_HIDE = 0;
    private const int SW_SHOW = 1;

    protected static int Handle
    {
        get
        {
            return FindWindow("Shell_TrayWnd", "");
        }
    }

    protected static int HandleOfStartButton
    {
        get
        {
            int handleOfDesktop = GetDesktopWindow();
            int handleOfStartButton = FindWindowEx(handleOfDesktop, 0, "button", 0);
            return handleOfStartButton;
        }
    }

    private Taskbar()
    {
        // hide ctor
    }

    public static void Show()
    {
        ShowWindow(Handle, SW_SHOW);
        ShowWindow(HandleOfStartButton, SW_SHOW);
    }

    public static void Hide()
    {
        ShowWindow(Handle, SW_HIDE);
        ShowWindow(HandleOfStartButton, SW_HIDE);
    }
}
    /// <summary>
    /// This class will help you to hide or show 
    /// a winform in full screen mode. 
    /// Any one can use this source code without restriction.
    /// I'm not responsible for any error.
    /// </summary>
    public class FullScreen
    {
        private Form _Form;
        private FormWindowState _cWindowState;
        private FormBorderStyle _cBorderStyle;
        private Rectangle _cBounds;
        private bool _FullScreen;

        /// <summary>
        /// Full screen constructor.
        /// </summary>
        /// <param name="form">The WinForm to be show or hide as full screen</param>
        public FullScreen(Form form)
        {
            _Form = form;
            _FullScreen = false;
        }

        /// <summary>
        /// Show or Hide your WinForm in full screen mode.
        /// </summary>
        private void ScreenMode(bool mode)
        {

            // set full screen
            if (!mode)
            {
                // Get the WinForm properties
                _cBorderStyle = _Form.FormBorderStyle;
                _cBounds = _Form.Bounds;
                _cWindowState = _Form.WindowState;

                // set to false to avoid site effect
                _Form.Visible = false;

                HandleTaskBar.hideTaskBar();

                // set new properties
                _Form.FormBorderStyle = FormBorderStyle.None;
                _Form.WindowState = FormWindowState.Maximized;

                _Form.Visible = true;
                _FullScreen = true;
            }
            else  // reset full screen
            {
                // reset the normal WinForm properties
                // always set WinForm.Visible to false to avoid site effect
                _Form.Visible = false;
                _Form.WindowState = _cWindowState;
                _Form.FormBorderStyle = _cBorderStyle;
                _Form.Bounds = _cBounds;

                HandleTaskBar.showTaskBar();

                _Form.Visible = true;

                // Not in full screen mode
                _FullScreen = false;
            }
        }

        /// <summary>
        /// Show or hide full screen mode
        /// </summary>
        public void ShowFullScreen(bool mode)
        {
            ScreenMode(mode);
        }
        /// <summary>
        /// You can use this to reset the Taskbar in case of error.
        /// I don't want to handle exception in this class.
        /// You can change it if you like!
        /// </summary>
        public void ResetTaskBar()
        {
            HandleTaskBar.showTaskBar();
        }
    }
    /// <summary>
    /// This class will show or hide windows taskbar for full screen mode.
    /// </summary>
    internal class HandleTaskBar
    {
        private const int SWP_HIDEWINDOW = 0x0080;
        private const int SWP_SHOWWINDOW = 0x0040;

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public HandleTaskBar()
        {
        }

        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        private static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        private static extern int SetWindowPos(int hWnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

        /// <summary>
        /// Show the TaskBar.
        /// </summary>
        public static void showTaskBar()
        {
            int hWnd = FindWindow("Shell_TrayWnd", "");
            SetWindowPos(hWnd, 0, 0, 0, 0, 0, SWP_SHOWWINDOW);
        }

        /// <summary>
        /// Hide the TaskBar.
        /// </summary>
        public static void hideTaskBar()
        {
            int hWnd = FindWindow("Shell_TrayWnd", "");
            SetWindowPos(hWnd, 0, 0, 0, 0, 0, SWP_HIDEWINDOW);
        }
    }