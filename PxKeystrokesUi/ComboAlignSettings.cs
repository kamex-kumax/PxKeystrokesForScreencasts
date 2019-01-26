//Necessary For APIs
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PxKeystrokesUi
{
    //Inherits ComboBox
    public class ComboAlignSettings : ComboBox
    {
        //Retrieve Info About Specified Window
        [DllImport("user32", CharSet = CharSet.Auto)]
        public extern static int GetWindowLong(IntPtr hwnd, int nIndex);

        //Change An Attribute Of Specified Window
        [DllImport("user32")]
        public static extern int SetWindowLong(IntPtr hwnd, int nIndex,
           int dwNewLong);

        //Retrieve Info About Specified Combo Box
        [DllImport("user32.dll")]
        public static extern int GetComboBoxInfo(IntPtr hWnd,
           ref ComboBoxINFO pcbi);


        [StructLayout(LayoutKind.Sequential)]
        public struct ComboBoxINFO    //Contains ComboBox Status Info
        {
            public Int32 cbSize;
            public RECT rcItem;
            public RECT rcButton;
            public CASComboBoxButtonState caState;
            public IntPtr hwndCombo;
            public IntPtr hwndEdit;
            public IntPtr hwndList;
        }

        //Describes Width, Height, And Location Of A Rectangle
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        //Determines Current State Of ComboBox
        public enum CASComboBoxButtonState
        {
            STATE_SYSTEM_NONE = 0,
            STATE_SYSTEM_INVISIBLE = 0x00008000,
            STATE_SYSTEM_PRESSED = 0x00000008
        }

        /// <summary>
        /// Alignment Enum For Left & Right
        /// </summary>
        public enum CASAlignment
        {
            CASLeft = 0,
            CASRight = 1
        }

        //ComboBox Style
        private const int GWL_EXSTYLE = -20;
        //Right Align Text
        private const int WS_EX_RIGHT = 4096;
        //Left ScrollBar
        private const int WS_EX_LEFTSCROLLBAR = 16384;
        //Show Drop Down
        private const int CB_SHOWDROPDOWN = 335;

        private IntPtr CASHandle; //Handle Of ComboBox

        //Alignment Options For Text
        private CASAlignment CASList;
        //Alignment Options For Button
        private CASAlignment CASButton;
        //Alignment Options For ScrollBar
        private CASAlignment CASScroll;

        public ComboAlignSettings()
        {
            CASHandle = CASGetHandle(this);    //Get Handle Of ComboBox

            //Set Alignments
            CASButton = CASAlignment.CASRight;
            CASScroll = CASAlignment.CASRight;
            CASList = CASAlignment.CASLeft;
        }

        /// <summary>
        /// Retrieves ComboBox Handle
        /// </summary>
        /// <param name="CASCombo"></param>
        /// <returns></returns>
        public IntPtr CASGetHandle(ComboBox CASCombo)
        {
            //New ComboBox Settings Object
            ComboBoxINFO CASCBI = new ComboBoxINFO();
            //Call In Correct Size
            CASCBI.cbSize =
               System.Runtime.InteropServices.Marshal.SizeOf(CASCBI);
            GetComboBoxInfo(CASCombo.Handle, ref CASCBI);    //Obtain Handle
            return CASCBI.hwndList;                          //Return Handle
        }

        /// <summary>
        /// Align The ComboBox List
        /// </summary>
        private void CASAlignList()
        {
            if (CASHandle != IntPtr.Zero)    //If Valid Handle
            {
                //Get ComboBox Style
                int CASStyle = GetWindowLong(CASHandle, GWL_EXSTYLE);
                switch (CASList)
                {
                    case CASAlignment.CASRight:
                        //Align Text To The Right
                        CASStyle = CASStyle | WS_EX_RIGHT;
                        break;
                }
                //Apply On ComboBox
                SetWindowLong(CASHandle, GWL_EXSTYLE, CASStyle);
            }
        }
        /// <summary>
        /// Align The ComboBox ScrollBar
        /// </summary>
        private void CASAlignScroll()
        {
            if (CASHandle != IntPtr.Zero)    //If Valid Handle
            {
                //Get ComboBox Style
                int CASStyle = GetWindowLong(CASHandle, GWL_EXSTYLE);
                switch (CASScroll)
                {
                    case CASAlignment.CASLeft:
                        //Align ScrollBare To The Left
                        CASStyle = CASStyle | WS_EX_LEFTSCROLLBAR;
                        break;
                }
                //Apply On ComboBox
                SetWindowLong(CASHandle, GWL_EXSTYLE, CASStyle);
            }
        }

        /// <summary>
        /// Align The ComboBox Button
        /// </summary>
        private void CASAlignButton()
        {
            if (CASHandle != IntPtr.Zero)    //If Valid Handle
            {
                //Get ComboBox Style
                int CASStyle = GetWindowLong(this.Handle, GWL_EXSTYLE);

                switch (CASButton)
                {
                    case CASAlignment.CASLeft:
                        //Align ComboBox Button To The Left
                        CASStyle = CASStyle | WS_EX_RIGHT;
                        break;

                }

                //Apply On ComboBox
                SetWindowLong(this.Handle, GWL_EXSTYLE, CASStyle);
            }

        }
    }
}