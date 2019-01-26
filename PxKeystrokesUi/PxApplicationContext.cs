using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace PxKeystrokesUi
{


    class PxApplicationContext : ApplicationContext
    {
        KeystrokesDisplay myUi;

        public PxApplicationContext()
        {
            Log.SetTagFilter("NONE");

            Application.ApplicationExit += Application_ApplicationExit;

            ImageResources.Init();
            InitSettings();
            InitKeyboardInterception();

            mySettings.settingChanged += OnSettingChanged;

            myUi = new KeystrokesDisplay(myKeystrokeConverter, mySettings);
            myUi.FormClosed += OnUiClosed;
            myUi.Show();
            this.MainForm = myUi;

            OnCursorIndicatorSettingChanged();
            OnButtonIndicatorSettingChanged();
        }

        SettingsStore mySettings;

        private void InitSettings()
        {
            mySettings = new SettingsStore();

            Rectangle R = Screen.PrimaryScreen.WorkingArea;
            mySettings.WindowLocationDefault = new Point(R.Right - mySettings.WindowSizeDefault.Width - 20,
                R.Bottom - mySettings.WindowSizeDefault.Height);

            //
            mySettings.ClearAll(); // test defaults
            mySettings.LoadAll();
        }

        private static List<string> GetAvailableCultureNames()
        {
            List<string> culNames = new List<string>();
            CultureInfo _nrCult = null;
            CultureInfo[] _nCults = CultureInfo.GetCultures(CultureTypes.NeutralCultures);
            Assembly _assembly = Assembly.GetExecutingAssembly();

            try
            {
                Attribute _attr = Attribute.GetCustomAttribute(_assembly, typeof(NeutralResourcesLanguageAttribute));
                _nrCult = new CultureInfo(_attr.ToString());
                culNames.Add(_nrCult.Name);
            }
            catch (Exception e)
            {

            }

            foreach (CultureInfo _cult in _nCults)
            {
                try
                {
                    _assembly.GetSatelliteAssembly(_cult);
                }
                catch (Exception e)
                {
                    continue;
                }
                culNames.Add(_cult.Name);
            }
            return culNames;
        }

        IKeyboardRawEventProvider myKeyboardHook;
        IKeystrokeEventProvider myKeystrokeConverter;

        private void InitKeyboardInterception()
        {
            myKeyboardHook = new KeyboardHook();
            myKeystrokeConverter = new KeystrokeParser(myKeyboardHook);
        }

        private void OnUiClosed(object sender, EventArgs e)
        {
            DisableCursorIndicator();
            DisableButtonIndicator();
            ExitThread();
        }

        void Application_ApplicationExit(object sender, EventArgs e)
        {
            DisableCursorIndicator();
            DisableButtonIndicator();
            myUi.Close();
        }

        private void OnSettingChanged(SettingsChangedEventArgs e)
        {
            switch (e.Name)
            {
                case "EnableCursorIndicator":
                    OnCursorIndicatorSettingChanged();
                    break;
                case "ButtonIndicator":
                    OnButtonIndicatorSettingChanged();
                    break;
            }
        }

        private void OnButtonIndicatorSettingChanged()
        {
            if ( mySettings.ButtonIndicator == ButtonIndicatorType.Disabled)
            {
                DisableButtonIndicator();
            }
            else
            {
                EnableButtonIndicator();
            }
        }

        ButtonIndicator myButtons = null;

        private void EnableButtonIndicator()
        {
            if (myButtons != null)
                return;
            Log.e("BI", "EnableButtonIndicator");
            EnableMouseHook();
            myButtons = new ButtonIndicator(myMouseHook, mySettings);
            myButtons.FormClosed += myButton_FormClosed;
            myButtons.Show();
        }

        private void myButton_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void DisableButtonIndicator()
        {
            if (myButtons == null)
                return;
            myButtons.Close();
            myButtons = null;
            DisableMouseHookIfNotNeeded();
            Log.e("BI", "DisableButtonIndicator");
        }

        private void OnCursorIndicatorSettingChanged()
        {
            if (mySettings.EnableCursorIndicator)
            {
                EnableCursorIndicator();
            }
            else
            {
                DisableCursorIndicator();
            }
        }

        CursorIndicator myCursor = null;

        private void EnableCursorIndicator()
        {
            if (myCursor != null)
                return;
            Log.e("CI", "EnableCursorIndicator");
            EnableMouseHook();
            myCursor = new CursorIndicator(myMouseHook, mySettings);
            myCursor.FormClosed += myCursor_FormClosed;
            myCursor.Show();
        }

        void myCursor_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void DisableCursorIndicator()
        {
            if (myCursor == null)
                return;
            myCursor.Close();
            myCursor = null;
            DisableMouseHookIfNotNeeded();
            Log.e("CI", "DisableCursorIndicator");
        }

        IMouseRawEventProvider myMouseHook = null;

        private void EnableMouseHook()
        {
            if (myMouseHook != null)
                return;
                //DisableMouseHook();
            myMouseHook = new MouseHook();
        }

        private void DisableMouseHookIfNotNeeded()
        {
            if (myCursor == null && myButtons == null)
                DisableMouseHook();
        }

        private void DisableMouseHook()
        {
            if (myMouseHook == null)
                return;
            myMouseHook.Dispose();
            myMouseHook = null;
        }
    }
}
