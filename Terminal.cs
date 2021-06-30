using System;
using static System.Console;
using System.Runtime.InteropServices;

static class Terminal
{
    // Fields required for fixed sized console method
    private const int MF_BYCOMMAND = 0x00000000;
    public const int SC_MINIMIZE = 0xF020;
    public const int SC_MAXIMIZE = 0xF030;
    public const int SC_SIZE = 0xF000;

    [DllImport("user32.dll")]
    public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

    [DllImport("user32.dll")]
    private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

    [DllImport("kernel32.dll", ExactSpelling = true)]
    private static extern IntPtr GetConsoleWindow();

    // Fixed size console method
    public static void Fixed(string heading, bool visible, int width, int height)
    {
        IntPtr handle = GetConsoleWindow();
	IntPtr sysMenu = GetSystemMenu(handle, false);

	if (handle != IntPtr.Zero)
	{
	    DeleteMenu(sysMenu, SC_MINIMIZE, MF_BYCOMMAND);
	    DeleteMenu(sysMenu, SC_MAXIMIZE, MF_BYCOMMAND);
	    DeleteMenu(sysMenu, SC_SIZE, MF_BYCOMMAND);
	}

	SetWindowSize(width, height);
	SetBufferSize(width, height);

	CursorVisible = visible;
	Title = heading;
    }
}
