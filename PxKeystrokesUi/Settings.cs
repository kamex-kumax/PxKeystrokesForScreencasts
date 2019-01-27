using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PxKeystrokesUi
{
    public partial class Settings : Form
    {
        public Settings(SettingsStore s)
        {
            this.settings = s;
            InitializeComponent();

            SetFormStyles();

            //bool b = AllowTransparency;
            //if (b) Console.WriteLine("true");
            //else Console.WriteLine("false");

            UpdateSliderValues();
            UpdateRadioButtons();
            UpdateCheckboxes();
            UpdateAllDisplayLabel();

            //BackColor = Color.Lavender;
            //TransparencyKey = Color.Lavender;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UrlOpener.OpenGithub();
        }

        void SetFormStyles()
        {
            //List<CultureInfo> availCultNames = new List<CultureInfo> { new CultureInfo("en"), new CultureInfo("ja") };
            //this.bindingList = new BindingList<CultureInfo>(availCultNames);
            //this.cmb_language.DataSource = this.bindingList;
            //this.cmb_language.SelectedIndex = 0;

        }

        SettingsStore settings;

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.SaveAll();
        }
        /*
        private void avilableCultureNames_CheckedChanged(object sender, EventArgs e)
        {
            settings.AvilableCultureNames = AvilableCultureNames;
        }
        */
        private void rb_align_left_CheckedChanged(object sender, EventArgs e)
        {
            settings.LabelTextAlignment = TextAlignent.Left;
        }

        private void rb_align_center_CheckedChanged(object sender, EventArgs e)
        {
            settings.LabelTextAlignment = TextAlignent.Center;
        }

        private void rb_align_right_CheckedChanged(object sender, EventArgs e)
        {
            settings.LabelTextAlignment = TextAlignent.Right;
        }

        private void rb_td_down_CheckedChanged(object sender, EventArgs e)
        {
            settings.LabelTextDirection = TextDirection.Down;
        }

        private void rb_td_up_CheckedChanged(object sender, EventArgs e)
        {
            settings.LabelTextDirection = TextDirection.Up;
        }

        private void rb_style_noani_CheckedChanged(object sender, EventArgs e)
        {
            settings.LabelAnimation = Style.NoAnimation;
        }

        private void rb_style_slide_CheckedChanged(object sender, EventArgs e)
        {
            settings.LabelAnimation = Style.Slide;
        }

        private void cb_cursorindicator_CheckedChanged(object sender, EventArgs e)
        {
            settings.EnableCursorIndicator = cb_cursorindicator.Checked;
        }

        private void button_textcolor_Click(object sender, EventArgs e)
        {
            picker_textcolor.Color = settings.TextColor;
            if(picker_textcolor.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                settings.TextColor = picker_textcolor.Color;
            }
        }

        private void button_textfont_Click(object sender, EventArgs e)
        {
            fontDialog_text.Font = settings.LabelFont;
            if(fontDialog_text.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                settings.LabelFont = fontDialog_text.Font;
                UpdateSliderValues();
            }
        }

        private void slider_fontsize_Scroll(object sender, EventArgs e)
        {
            float newsize = (float)slider_fontsize.Value / 100f;
            settings.LabelFont = new Font(settings.LabelFont.FontFamily, newsize, settings.LabelFont.Style);
        }

        private void button_backcolor_Click(object sender, EventArgs e)
        {
            picker_backcolor.Color = settings.BackgroundColor;
            if (picker_backcolor.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                settings.BackgroundColor = picker_backcolor.Color;
            }
        }

        private void slider_opacity_Scroll(object sender, EventArgs e)
        {
            settings.Opacity = (float)slider_opacity.Value / 100f;
        }

        private void nud_verticalDistance_ValueChanged(object sender, EventArgs e)
        {
            settings.LineDistance = (int)nud_verticalDistance.Value;
        }

        private void nud_historycount_ValueChanged(object sender, EventArgs e)
        {
            settings.HistoryLength = (int)nud_historycount.Value;
        }

        private void cb_enableHistoryTimeout_CheckedChanged(object sender, EventArgs e)
        {
            settings.EnableHistoryTimeout = cb_enableHistoryTimeout.Checked;
        }

        private void slider_history_timeout_Scroll(object sender, EventArgs e)
        {
            settings.HistoryTimeout = slider_history_timeout.Value;
            UpdateHistoryTimeoutDisplayLabel();
        }

        private void slider_ci_opacity_Scroll(object sender, EventArgs e)
        {
            settings.CursorIndicatorOpacity = (float)slider_ci_opacity.Value / 100f;
        }

        private void slider_ci_size_Scroll(object sender, EventArgs e)
        {
            settings.CursorIndicatorSize = slider_ci_size.Value;
        }

        private void button_ci_color_Click(object sender, EventArgs e)
        {
            picker_ci_color.Color = settings.CursorIndicatorColor;
            if (picker_ci_color.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                settings.CursorIndicatorColor = picker_ci_color.Color;
            }
        }

        private void rb_bi_disable_CheckedChanged(object sender, EventArgs e)
        {
            settings.ButtonIndicator = ButtonIndicatorType.Disabled;
        }

        private void rb_bi_icon_CheckedChanged(object sender, EventArgs e)
        {
            settings.ButtonIndicator = ButtonIndicatorType.PicsAroundCursor;
        }

        private void rb_bi_simple_CheckedChanged(object sender, EventArgs e)
        {
            settings.ButtonIndicator = ButtonIndicatorType.GrphOverCursor;
        }

        private void slider_bi_size_Scroll(object sender, EventArgs e)
        {
            settings.ButtonIndicatorSize = slider_bi_size.Value;
        }

        private void slider_bi_distance_Scroll(object sender, EventArgs e)
        {
            settings.ButtonIndicatorPositionDistance = slider_bi_distance.Value;
        }

        private void slider_bi_angle_Scroll(object sender, EventArgs e)
        {
            settings.ButtonIndicatorPositionAngle = slider_bi_angle.Value;
        }

        private void cb_backspace_CheckedChanged(object sender, EventArgs e)
        {
            settings.BackspaceDeletesText = cb_backspace.Checked;
        }

        private void cb_bi_history_CheckedChanged(object sender, EventArgs e)
        {
            settings.AddButtonEventsToHistory = cb_bi_history.Checked;
        }

        private void UpdateSliderValues()
        {
            ExtendTrackbarRangeIfNeeded(slider_fontsize, (int)(settings.LabelFont.SizeInPoints * 100f));

            slider_opacity.Value = (int)(settings.Opacity * 100f);

            ExtendTrackbarRangeIfNeeded(slider_ci_size, settings.CursorIndicatorSize);
            slider_ci_opacity.Value = (int)(settings.CursorIndicatorOpacity * 100f);

            nud_historycount.Value = settings.HistoryLength;
            nud_verticalDistance.Value = settings.LineDistance;
            ExtendTrackbarRangeIfNeeded(slider_history_timeout, settings.HistoryTimeout);

            ExtendTrackbarRangeIfNeeded(slider_bi_angle, settings.ButtonIndicatorPositionAngle);
            ExtendTrackbarRangeIfNeeded(slider_bi_distance, settings.ButtonIndicatorPositionDistance);
            ExtendTrackbarRangeIfNeeded(slider_bi_size, settings.ButtonIndicatorSize);
        }

        private void ExtendTrackbarRangeIfNeeded(TrackBar slider, int value)
        {
            slider.Maximum = Math.Max(slider.Maximum, value);
            slider.Minimum = Math.Min(slider.Minimum, value);
            slider.Value = value;
        }

        private void UpdateRadioButtons()
        {
            switch (settings.LabelAnimation)
            {
                case Style.NoAnimation:
                    rb_style_noani.Checked = true;
                    break;
                case Style.Slide:
                    rb_style_slide.Checked = true;
                    break;
            }

            switch (settings.LabelTextAlignment)
            {
                case TextAlignent.Right:
                    rb_align_right.Checked = true;
                    break;
                case TextAlignent.Center:
                    rb_align_center.Checked = true;
                    break;
                case TextAlignent.Left:
                    rb_align_left.Checked = true;
                    break;
            }

            switch (settings.LabelTextDirection)
            {
                case TextDirection.Up:
                    rb_td_up.Checked = true;
                    break;
                case TextDirection.Down:
                    rb_td_down.Checked = true;
                    break;
            }

            switch(settings.ButtonIndicator)
            {
                case ButtonIndicatorType.Disabled:
                    rb_bi_disable.Checked = true;
                    break;
                case ButtonIndicatorType.PicsAroundCursor:
                    rb_bi_icon.Checked = true;
                    break;
                case ButtonIndicatorType.GrphOverCursor:
                    rb_bi_simple.Checked = true;
                    break;
            }
        }

        private void UpdateCheckboxes()
        {
            cb_cursorindicator.Checked = settings.EnableCursorIndicator;
            cb_enableHistoryTimeout.Checked = settings.EnableHistoryTimeout;
            cb_hideWindow.Checked = settings.EnableWindowFade;
            cb_bi_history.Checked = settings.AddButtonEventsToHistory;
            cb_backspace.Checked = settings.BackspaceDeletesText;
        }

        private void UpdateFontSizeDisplayLabel()
        {
            label_fontsize_display.Text = ((int)(slider_fontsize.Value / 100f)).ToString();
        }

        private void UpdateHistoryTimeoutDisplayLabel()
        {
            label_timeout_display.Text = (slider_history_timeout.Value / 1000).ToString() + "s";
        }

        private void UpdateCiOpacityDisplayLabel()
        {
        }

        private void UpdateCiSizeDisplayDisplayLabel()
        {
            label_ci_size_display.Text = (slider_ci_size.Value).ToString();
        }

        private void UpdateOpacityDisplayLabel()
        {
            label_opacity_display.Text = ((int)(slider_opacity.Value / 10f) / 10).ToString();
        }

        private void UpdateBiSizeDisplayLabel()
        {
            label_bi_size_display.Text = (slider_bi_size.Value).ToString();
        }

        private void UpdateBiDistanceDisplayLabel()
        {
            label_bi_distance_display.Text = (slider_bi_distance.Value).ToString();
        }

        private void UpdateBiAngleDisplayLabel()
        {
            label_bi_angle_display.Text = (slider_bi_angle.Value).ToString();
        }

        private void UpdateAllDisplayLabel()
        {
            UpdateFontSizeDisplayLabel();
            UpdateHistoryTimeoutDisplayLabel();
            UpdateCiOpacityDisplayLabel();
            UpdateCiSizeDisplayDisplayLabel();
            UpdateOpacityDisplayLabel();
            UpdateBiSizeDisplayLabel();
            UpdateBiDistanceDisplayLabel();
            UpdateBiAngleDisplayLabel();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            cmb_language.DrawItem += new DrawItemEventHandler(RightAlignDrawItem);
        }

        private void RightAlignDrawItem(object sender, DrawItemEventArgs e)
        {
            // By using Sender, one method could handle multiple ComboBoxes
            ComboBox _cmb = sender as ComboBox;
            if (_cmb != null)
            {
                // Always draw the background
                e.DrawBackground();

                // Drawing one of the items?
                if (e.Index >= 0)
                {
                    // Set the string alignment.  Choices are Center, Near and Far
                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Far;
                    sf.Alignment = StringAlignment.Far;

                    // Set the Brush to ComboBox ForeColor to maintain any ComboBox color settings
                    // Assumes Brush is solid
                    Brush brush = new SolidBrush(_cmb.ForeColor);

                    // If drawing highlighted selection, change brush
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                        brush = SystemBrushes.HighlightText;

                    // Draw the string
                    e.Graphics.DrawString(_cmb.Items[e.Index].ToString(), _cmb.Font, brush, e.Bounds, sf);
                }
            }
        }

        private void bn_reset_position_Click(object sender, EventArgs e)
        {
            settings.PanelLocation = settings.PanelLocationDefault;
            settings.PanelSize = settings.PanelSizeDefault;
            settings.WindowLocation = settings.WindowLocationDefault;
            settings.WindowSize = settings.WindowSizeDefault;
        }

        private void bn_reset_all_Click(object sender, EventArgs e)
        {
            settings.ClearAll();
            settings.LoadAll();
            settings.OnSettingChangedAll();
            UpdateSliderValues();
            UpdateRadioButtons();
            UpdateCheckboxes();
            UpdateAllDisplayLabel();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_hideWindow_CheckedChanged(object sender, EventArgs e)
        {
            settings.EnableWindowFade = cb_hideWindow.Checked;
        }

        private void cmb_language_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
