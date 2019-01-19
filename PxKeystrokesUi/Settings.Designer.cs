using System.Globalization;

namespace PxKeystrokesUi
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.button_backcolor = new System.Windows.Forms.Button();
            this.button_textcolor = new System.Windows.Forms.Button();
            this.slider_opacity = new System.Windows.Forms.TrackBar();
            this.label_opacity = new System.Windows.Forms.Label();
            this.label_fontsize = new System.Windows.Forms.Label();
            this.rb_align_left = new System.Windows.Forms.RadioButton();
            this.rb_align_center = new System.Windows.Forms.RadioButton();
            this.rb_align_right = new System.Windows.Forms.RadioButton();
            this.gb_text_alignment = new System.Windows.Forms.GroupBox();
            this.gb_textdir = new System.Windows.Forms.GroupBox();
            this.rb_td_up = new System.Windows.Forms.RadioButton();
            this.rb_td_down = new System.Windows.Forms.RadioButton();
            this.gb_style = new System.Windows.Forms.GroupBox();
            this.rb_style_slide = new System.Windows.Forms.RadioButton();
            this.rb_style_noani = new System.Windows.Forms.RadioButton();
            this.gb_text = new System.Windows.Forms.GroupBox();
            this.label_fontsize_display = new System.Windows.Forms.Label();
            this.button_textfont = new System.Windows.Forms.Button();
            this.cb_hideWindow = new System.Windows.Forms.CheckBox();
            this.cb_backspace = new System.Windows.Forms.CheckBox();
            this.label_timeout_display = new System.Windows.Forms.Label();
            this.cb_enableHistoryTimeout = new System.Windows.Forms.CheckBox();
            this.slider_history_timeout = new System.Windows.Forms.TrackBar();
            this.label_history_timeout = new System.Windows.Forms.Label();
            this.label_historycount = new System.Windows.Forms.Label();
            this.label_verticalDistance = new System.Windows.Forms.Label();
            this.nud_historycount = new System.Windows.Forms.NumericUpDown();
            this.nud_verticalDistance = new System.Windows.Forms.NumericUpDown();
            this.slider_fontsize = new System.Windows.Forms.TrackBar();
            this.gb_background = new System.Windows.Forms.GroupBox();
            this.label_opacity_display = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.picker_textcolor = new System.Windows.Forms.ColorDialog();
            this.picker_backcolor = new System.Windows.Forms.ColorDialog();
            this.fontDialog_text = new System.Windows.Forms.FontDialog();
            this.bn_reset_position = new System.Windows.Forms.Button();
            this.bn_reset_all = new System.Windows.Forms.Button();
            this.gb_mouse = new System.Windows.Forms.GroupBox();
            this.label_ci_opacity = new System.Windows.Forms.Label();
            this.label_ci_size_display = new System.Windows.Forms.Label();
            this.label_ci_opacity_display = new System.Windows.Forms.Label();
            this.button_ci_color = new System.Windows.Forms.Button();
            this.label_ci_size = new System.Windows.Forms.Label();
            this.slider_ci_size = new System.Windows.Forms.TrackBar();
            this.slider_ci_opacity = new System.Windows.Forms.TrackBar();
            this.cb_cursorindicator = new System.Windows.Forms.CheckBox();
            this.picker_ci_color = new System.Windows.Forms.ColorDialog();
            this.gb_buttonindicator = new System.Windows.Forms.GroupBox();
            this.rb_bi_simple = new System.Windows.Forms.RadioButton();
            this.label_bi_angle_display = new System.Windows.Forms.Label();
            this.label_bi_distance_display = new System.Windows.Forms.Label();
            this.label_bi_size_display = new System.Windows.Forms.Label();
            this.cb_bi_history = new System.Windows.Forms.CheckBox();
            this.label_bi_size = new System.Windows.Forms.Label();
            this.rb_bi_icon = new System.Windows.Forms.RadioButton();
            this.rb_bi_disable = new System.Windows.Forms.RadioButton();
            this.label_bi_angle = new System.Windows.Forms.Label();
            this.slider_bi_angle = new System.Windows.Forms.TrackBar();
            this.slider_bi_distance = new System.Windows.Forms.TrackBar();
            this.label_bi_distance = new System.Windows.Forms.Label();
            this.slider_bi_size = new System.Windows.Forms.TrackBar();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.cmb_language = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.slider_opacity)).BeginInit();
            this.gb_text_alignment.SuspendLayout();
            this.gb_textdir.SuspendLayout();
            this.gb_style.SuspendLayout();
            this.gb_text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_history_timeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_historycount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_verticalDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_fontsize)).BeginInit();
            this.gb_background.SuspendLayout();
            this.gb_mouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_ci_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_ci_opacity)).BeginInit();
            this.gb_buttonindicator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_bi_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_bi_distance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_bi_size)).BeginInit();
            this.SuspendLayout();
            // 
            // button_backcolor
            // 
            resources.ApplyResources(this.button_backcolor, "button_backcolor");
            this.button_backcolor.Name = "button_backcolor";
            this.button_backcolor.UseVisualStyleBackColor = true;
            this.button_backcolor.Click += new System.EventHandler(this.button_backcolor_Click);
            // 
            // button_textcolor
            // 
            resources.ApplyResources(this.button_textcolor, "button_textcolor");
            this.button_textcolor.Name = "button_textcolor";
            this.button_textcolor.UseVisualStyleBackColor = true;
            this.button_textcolor.Click += new System.EventHandler(this.button_textcolor_Click);
            // 
            // slider_opacity
            // 
            resources.ApplyResources(this.slider_opacity, "slider_opacity");
            this.slider_opacity.Maximum = 100;
            this.slider_opacity.Minimum = 10;
            this.slider_opacity.Name = "slider_opacity";
            this.slider_opacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_opacity.Value = 80;
            this.slider_opacity.Scroll += new System.EventHandler(this.slider_opacity_Scroll);
            // 
            // label_opacity
            // 
            resources.ApplyResources(this.label_opacity, "label_opacity");
            this.label_opacity.Name = "label_opacity";
            // 
            // label_fontsize
            // 
            resources.ApplyResources(this.label_fontsize, "label_fontsize");
            this.label_fontsize.Name = "label_fontsize";
            // 
            // rb_align_left
            // 
            resources.ApplyResources(this.rb_align_left, "rb_align_left");
            this.rb_align_left.Name = "rb_align_left";
            this.rb_align_left.TabStop = true;
            this.rb_align_left.UseVisualStyleBackColor = true;
            this.rb_align_left.CheckedChanged += new System.EventHandler(this.rb_align_left_CheckedChanged);
            // 
            // rb_align_center
            // 
            resources.ApplyResources(this.rb_align_center, "rb_align_center");
            this.rb_align_center.Name = "rb_align_center";
            this.rb_align_center.TabStop = true;
            this.rb_align_center.UseVisualStyleBackColor = true;
            this.rb_align_center.CheckedChanged += new System.EventHandler(this.rb_align_center_CheckedChanged);
            // 
            // rb_align_right
            // 
            resources.ApplyResources(this.rb_align_right, "rb_align_right");
            this.rb_align_right.Name = "rb_align_right";
            this.rb_align_right.TabStop = true;
            this.rb_align_right.UseVisualStyleBackColor = true;
            this.rb_align_right.CheckedChanged += new System.EventHandler(this.rb_align_right_CheckedChanged);
            // 
            // gb_text_alignment
            // 
            resources.ApplyResources(this.gb_text_alignment, "gb_text_alignment");
            this.gb_text_alignment.Controls.Add(this.rb_align_left);
            this.gb_text_alignment.Controls.Add(this.rb_align_right);
            this.gb_text_alignment.Controls.Add(this.rb_align_center);
            this.gb_text_alignment.Name = "gb_text_alignment";
            this.gb_text_alignment.TabStop = false;
            // 
            // gb_textdir
            // 
            resources.ApplyResources(this.gb_textdir, "gb_textdir");
            this.gb_textdir.Controls.Add(this.rb_td_up);
            this.gb_textdir.Controls.Add(this.rb_td_down);
            this.gb_textdir.Name = "gb_textdir";
            this.gb_textdir.TabStop = false;
            // 
            // rb_td_up
            // 
            resources.ApplyResources(this.rb_td_up, "rb_td_up");
            this.rb_td_up.Name = "rb_td_up";
            this.rb_td_up.TabStop = true;
            this.rb_td_up.UseVisualStyleBackColor = true;
            this.rb_td_up.CheckedChanged += new System.EventHandler(this.rb_td_up_CheckedChanged);
            // 
            // rb_td_down
            // 
            resources.ApplyResources(this.rb_td_down, "rb_td_down");
            this.rb_td_down.Name = "rb_td_down";
            this.rb_td_down.TabStop = true;
            this.rb_td_down.UseVisualStyleBackColor = true;
            this.rb_td_down.CheckedChanged += new System.EventHandler(this.rb_td_down_CheckedChanged);
            // 
            // gb_style
            // 
            resources.ApplyResources(this.gb_style, "gb_style");
            this.gb_style.Controls.Add(this.rb_style_slide);
            this.gb_style.Controls.Add(this.rb_style_noani);
            this.gb_style.Name = "gb_style";
            this.gb_style.TabStop = false;
            // 
            // rb_style_slide
            // 
            resources.ApplyResources(this.rb_style_slide, "rb_style_slide");
            this.rb_style_slide.Name = "rb_style_slide";
            this.rb_style_slide.TabStop = true;
            this.rb_style_slide.UseVisualStyleBackColor = true;
            this.rb_style_slide.CheckedChanged += new System.EventHandler(this.rb_style_slide_CheckedChanged);
            // 
            // rb_style_noani
            // 
            resources.ApplyResources(this.rb_style_noani, "rb_style_noani");
            this.rb_style_noani.Name = "rb_style_noani";
            this.rb_style_noani.TabStop = true;
            this.rb_style_noani.UseVisualStyleBackColor = true;
            this.rb_style_noani.CheckedChanged += new System.EventHandler(this.rb_style_noani_CheckedChanged);
            // 
            // gb_text
            // 
            resources.ApplyResources(this.gb_text, "gb_text");
            this.gb_text.Controls.Add(this.label_fontsize_display);
            this.gb_text.Controls.Add(this.button_textfont);
            this.gb_text.Controls.Add(this.cb_hideWindow);
            this.gb_text.Controls.Add(this.cb_backspace);
            this.gb_text.Controls.Add(this.label_timeout_display);
            this.gb_text.Controls.Add(this.cb_enableHistoryTimeout);
            this.gb_text.Controls.Add(this.slider_history_timeout);
            this.gb_text.Controls.Add(this.label_history_timeout);
            this.gb_text.Controls.Add(this.label_historycount);
            this.gb_text.Controls.Add(this.label_verticalDistance);
            this.gb_text.Controls.Add(this.nud_historycount);
            this.gb_text.Controls.Add(this.nud_verticalDistance);
            this.gb_text.Controls.Add(this.button_textcolor);
            this.gb_text.Controls.Add(this.label_fontsize);
            this.gb_text.Controls.Add(this.slider_fontsize);
            this.gb_text.Name = "gb_text";
            this.gb_text.TabStop = false;
            // 
            // label_fontsize_display
            // 
            resources.ApplyResources(this.label_fontsize_display, "label_fontsize_display");
            this.label_fontsize_display.Name = "label_fontsize_display";
            // 
            // button_textfont
            // 
            resources.ApplyResources(this.button_textfont, "button_textfont");
            this.button_textfont.Name = "button_textfont";
            this.button_textfont.UseVisualStyleBackColor = true;
            // 
            // cb_hideWindow
            // 
            resources.ApplyResources(this.cb_hideWindow, "cb_hideWindow");
            this.cb_hideWindow.Name = "cb_hideWindow";
            this.cb_hideWindow.UseVisualStyleBackColor = true;
            this.cb_hideWindow.CheckedChanged += new System.EventHandler(this.cb_hideWindow_CheckedChanged);
            // 
            // cb_backspace
            // 
            resources.ApplyResources(this.cb_backspace, "cb_backspace");
            this.cb_backspace.Name = "cb_backspace";
            this.cb_backspace.UseVisualStyleBackColor = true;
            this.cb_backspace.CheckedChanged += new System.EventHandler(this.cb_backspace_CheckedChanged);
            // 
            // label_timeout_display
            // 
            resources.ApplyResources(this.label_timeout_display, "label_timeout_display");
            this.label_timeout_display.Name = "label_timeout_display";
            // 
            // cb_enableHistoryTimeout
            // 
            resources.ApplyResources(this.cb_enableHistoryTimeout, "cb_enableHistoryTimeout");
            this.cb_enableHistoryTimeout.Name = "cb_enableHistoryTimeout";
            this.cb_enableHistoryTimeout.UseVisualStyleBackColor = true;
            this.cb_enableHistoryTimeout.CheckedChanged += new System.EventHandler(this.cb_enableHistoryTimeout_CheckedChanged);
            // 
            // slider_history_timeout
            // 
            resources.ApplyResources(this.slider_history_timeout, "slider_history_timeout");
            this.slider_history_timeout.Maximum = 120000;
            this.slider_history_timeout.Minimum = 1000;
            this.slider_history_timeout.Name = "slider_history_timeout";
            this.slider_history_timeout.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_history_timeout.Value = 120000;
            this.slider_history_timeout.Scroll += new System.EventHandler(this.slider_history_timeout_Scroll);
            // 
            // label_history_timeout
            // 
            resources.ApplyResources(this.label_history_timeout, "label_history_timeout");
            this.label_history_timeout.Name = "label_history_timeout";
            // 
            // label_historycount
            // 
            resources.ApplyResources(this.label_historycount, "label_historycount");
            this.label_historycount.Name = "label_historycount";
            // 
            // label_verticalDistance
            // 
            resources.ApplyResources(this.label_verticalDistance, "label_verticalDistance");
            this.label_verticalDistance.Name = "label_verticalDistance";
            // 
            // nud_historycount
            // 
            resources.ApplyResources(this.nud_historycount, "nud_historycount");
            this.nud_historycount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_historycount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_historycount.Name = "nud_historycount";
            this.nud_historycount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_historycount.ValueChanged += new System.EventHandler(this.nud_historycount_ValueChanged);
            // 
            // nud_verticalDistance
            // 
            resources.ApplyResources(this.nud_verticalDistance, "nud_verticalDistance");
            this.nud_verticalDistance.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_verticalDistance.Name = "nud_verticalDistance";
            this.nud_verticalDistance.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_verticalDistance.ValueChanged += new System.EventHandler(this.nud_verticalDistance_ValueChanged);
            // 
            // slider_fontsize
            // 
            resources.ApplyResources(this.slider_fontsize, "slider_fontsize");
            this.slider_fontsize.BackColor = System.Drawing.SystemColors.Control;
            this.slider_fontsize.Maximum = 3000;
            this.slider_fontsize.Minimum = 800;
            this.slider_fontsize.Name = "slider_fontsize";
            this.slider_fontsize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_fontsize.Value = 800;
            this.slider_fontsize.Scroll += new System.EventHandler(this.slider_fontsize_Scroll);
            // 
            // gb_background
            // 
            resources.ApplyResources(this.gb_background, "gb_background");
            this.gb_background.Controls.Add(this.label_opacity_display);
            this.gb_background.Controls.Add(this.button_backcolor);
            this.gb_background.Controls.Add(this.slider_opacity);
            this.gb_background.Controls.Add(this.label_opacity);
            this.gb_background.Name = "gb_background";
            this.gb_background.TabStop = false;
            // 
            // label_opacity_display
            // 
            resources.ApplyResources(this.label_opacity_display, "label_opacity_display");
            this.label_opacity_display.Name = "label_opacity_display";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // bn_reset_position
            // 
            resources.ApplyResources(this.bn_reset_position, "bn_reset_position");
            this.bn_reset_position.Name = "bn_reset_position";
            this.bn_reset_position.UseVisualStyleBackColor = true;
            this.bn_reset_position.Click += new System.EventHandler(this.bn_reset_position_Click);
            // 
            // bn_reset_all
            // 
            resources.ApplyResources(this.bn_reset_all, "bn_reset_all");
            this.bn_reset_all.Name = "bn_reset_all";
            this.bn_reset_all.UseVisualStyleBackColor = true;
            this.bn_reset_all.Click += new System.EventHandler(this.bn_reset_all_Click);
            // 
            // gb_mouse
            // 
            resources.ApplyResources(this.gb_mouse, "gb_mouse");
            this.gb_mouse.Controls.Add(this.label_ci_opacity);
            this.gb_mouse.Controls.Add(this.label_ci_size_display);
            this.gb_mouse.Controls.Add(this.label_ci_opacity_display);
            this.gb_mouse.Controls.Add(this.button_ci_color);
            this.gb_mouse.Controls.Add(this.label_ci_size);
            this.gb_mouse.Controls.Add(this.slider_ci_size);
            this.gb_mouse.Controls.Add(this.slider_ci_opacity);
            this.gb_mouse.Controls.Add(this.cb_cursorindicator);
            this.gb_mouse.Name = "gb_mouse";
            this.gb_mouse.TabStop = false;
            // 
            // label_ci_opacity
            // 
            resources.ApplyResources(this.label_ci_opacity, "label_ci_opacity");
            this.label_ci_opacity.Name = "label_ci_opacity";
            // 
            // label_ci_size_display
            // 
            resources.ApplyResources(this.label_ci_size_display, "label_ci_size_display");
            this.label_ci_size_display.Name = "label_ci_size_display";
            // 
            // label_ci_opacity_display
            // 
            resources.ApplyResources(this.label_ci_opacity_display, "label_ci_opacity_display");
            this.label_ci_opacity_display.Name = "label_ci_opacity_display";
            // 
            // button_ci_color
            // 
            resources.ApplyResources(this.button_ci_color, "button_ci_color");
            this.button_ci_color.Name = "button_ci_color";
            this.button_ci_color.UseVisualStyleBackColor = true;
            this.button_ci_color.Click += new System.EventHandler(this.button_ci_color_Click);
            // 
            // label_ci_size
            // 
            resources.ApplyResources(this.label_ci_size, "label_ci_size");
            this.label_ci_size.Name = "label_ci_size";
            // 
            // slider_ci_size
            // 
            resources.ApplyResources(this.slider_ci_size, "slider_ci_size");
            this.slider_ci_size.Maximum = 200;
            this.slider_ci_size.Minimum = 4;
            this.slider_ci_size.Name = "slider_ci_size";
            this.slider_ci_size.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_ci_size.Value = 55;
            this.slider_ci_size.Scroll += new System.EventHandler(this.slider_ci_size_Scroll);
            // 
            // slider_ci_opacity
            // 
            resources.ApplyResources(this.slider_ci_opacity, "slider_ci_opacity");
            this.slider_ci_opacity.Maximum = 100;
            this.slider_ci_opacity.Minimum = 10;
            this.slider_ci_opacity.Name = "slider_ci_opacity";
            this.slider_ci_opacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_ci_opacity.Value = 80;
            this.slider_ci_opacity.Scroll += new System.EventHandler(this.slider_ci_opacity_Scroll);
            // 
            // cb_cursorindicator
            // 
            resources.ApplyResources(this.cb_cursorindicator, "cb_cursorindicator");
            this.cb_cursorindicator.Name = "cb_cursorindicator";
            this.cb_cursorindicator.UseVisualStyleBackColor = true;
            this.cb_cursorindicator.CheckedChanged += new System.EventHandler(this.cb_cursorindicator_CheckedChanged);
            // 
            // gb_buttonindicator
            // 
            resources.ApplyResources(this.gb_buttonindicator, "gb_buttonindicator");
            this.gb_buttonindicator.Controls.Add(this.rb_bi_simple);
            this.gb_buttonindicator.Controls.Add(this.label_bi_angle_display);
            this.gb_buttonindicator.Controls.Add(this.label_bi_distance_display);
            this.gb_buttonindicator.Controls.Add(this.label_bi_size_display);
            this.gb_buttonindicator.Controls.Add(this.cb_bi_history);
            this.gb_buttonindicator.Controls.Add(this.label_bi_size);
            this.gb_buttonindicator.Controls.Add(this.rb_bi_icon);
            this.gb_buttonindicator.Controls.Add(this.rb_bi_disable);
            this.gb_buttonindicator.Controls.Add(this.label_bi_angle);
            this.gb_buttonindicator.Controls.Add(this.slider_bi_angle);
            this.gb_buttonindicator.Controls.Add(this.slider_bi_distance);
            this.gb_buttonindicator.Controls.Add(this.label_bi_distance);
            this.gb_buttonindicator.Controls.Add(this.slider_bi_size);
            this.gb_buttonindicator.Name = "gb_buttonindicator";
            this.gb_buttonindicator.TabStop = false;
            // 
            // rb_bi_simple
            // 
            resources.ApplyResources(this.rb_bi_simple, "rb_bi_simple");
            this.rb_bi_simple.Name = "rb_bi_simple";
            this.rb_bi_simple.TabStop = true;
            this.rb_bi_simple.UseVisualStyleBackColor = true;
            // 
            // label_bi_angle_display
            // 
            resources.ApplyResources(this.label_bi_angle_display, "label_bi_angle_display");
            this.label_bi_angle_display.Name = "label_bi_angle_display";
            // 
            // label_bi_distance_display
            // 
            resources.ApplyResources(this.label_bi_distance_display, "label_bi_distance_display");
            this.label_bi_distance_display.Name = "label_bi_distance_display";
            // 
            // label_bi_size_display
            // 
            resources.ApplyResources(this.label_bi_size_display, "label_bi_size_display");
            this.label_bi_size_display.Name = "label_bi_size_display";
            // 
            // cb_bi_history
            // 
            resources.ApplyResources(this.cb_bi_history, "cb_bi_history");
            this.cb_bi_history.Name = "cb_bi_history";
            this.cb_bi_history.UseVisualStyleBackColor = true;
            this.cb_bi_history.CheckedChanged += new System.EventHandler(this.cb_bi_history_CheckedChanged);
            // 
            // label_bi_size
            // 
            resources.ApplyResources(this.label_bi_size, "label_bi_size");
            this.label_bi_size.Name = "label_bi_size";
            // 
            // rb_bi_icon
            // 
            resources.ApplyResources(this.rb_bi_icon, "rb_bi_icon");
            this.rb_bi_icon.Name = "rb_bi_icon";
            this.rb_bi_icon.TabStop = true;
            this.rb_bi_icon.UseVisualStyleBackColor = true;
            this.rb_bi_icon.CheckedChanged += new System.EventHandler(this.rb_bi_icon_CheckedChanged);
            // 
            // rb_bi_disable
            // 
            resources.ApplyResources(this.rb_bi_disable, "rb_bi_disable");
            this.rb_bi_disable.Name = "rb_bi_disable";
            this.rb_bi_disable.TabStop = true;
            this.rb_bi_disable.UseVisualStyleBackColor = true;
            this.rb_bi_disable.CheckedChanged += new System.EventHandler(this.rb_bi_disable_CheckedChanged);
            // 
            // label_bi_angle
            // 
            resources.ApplyResources(this.label_bi_angle, "label_bi_angle");
            this.label_bi_angle.Name = "label_bi_angle";
            // 
            // slider_bi_angle
            // 
            resources.ApplyResources(this.slider_bi_angle, "slider_bi_angle");
            this.slider_bi_angle.Maximum = 65;
            this.slider_bi_angle.Name = "slider_bi_angle";
            this.slider_bi_angle.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_bi_angle.Value = 65;
            this.slider_bi_angle.Scroll += new System.EventHandler(this.slider_bi_angle_Scroll);
            // 
            // slider_bi_distance
            // 
            resources.ApplyResources(this.slider_bi_distance, "slider_bi_distance");
            this.slider_bi_distance.Maximum = 100;
            this.slider_bi_distance.Minimum = 10;
            this.slider_bi_distance.Name = "slider_bi_distance";
            this.slider_bi_distance.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_bi_distance.Value = 80;
            this.slider_bi_distance.Scroll += new System.EventHandler(this.slider_bi_distance_Scroll);
            // 
            // label_bi_distance
            // 
            resources.ApplyResources(this.label_bi_distance, "label_bi_distance");
            this.label_bi_distance.Name = "label_bi_distance";
            // 
            // slider_bi_size
            // 
            resources.ApplyResources(this.slider_bi_size, "slider_bi_size");
            this.slider_bi_size.Maximum = 70;
            this.slider_bi_size.Minimum = 20;
            this.slider_bi_size.Name = "slider_bi_size";
            this.slider_bi_size.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slider_bi_size.Value = 70;
            this.slider_bi_size.Scroll += new System.EventHandler(this.slider_bi_size_Scroll);
            // 
            // button_exit
            // 
            resources.ApplyResources(this.button_exit, "button_exit");
            this.button_exit.Name = "button_exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_close
            // 
            resources.ApplyResources(this.button_close, "button_close");
            this.button_close.Name = "button_close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // cmb_language
            // 
            resources.ApplyResources(this.cmb_language, "cmb_language");
            this.cmb_language.FormattingEnabled = true;
            this.cmb_language.Name = "cmb_language";
            foreach(CultureInfo _cult in GetAvailableCultures())
            {
                this.cmb_language.Items.Add(_cult.DisplayName);
            }
            
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cmb_language);
            this.Controls.Add(this.gb_text);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.gb_buttonindicator);
            this.Controls.Add(this.gb_mouse);
            this.Controls.Add(this.bn_reset_all);
            this.Controls.Add(this.bn_reset_position);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_background);
            this.Controls.Add(this.gb_style);
            this.Controls.Add(this.gb_textdir);
            this.Controls.Add(this.gb_text_alignment);
            this.Name = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slider_opacity)).EndInit();
            this.gb_text_alignment.ResumeLayout(false);
            this.gb_text_alignment.PerformLayout();
            this.gb_textdir.ResumeLayout(false);
            this.gb_textdir.PerformLayout();
            this.gb_style.ResumeLayout(false);
            this.gb_style.PerformLayout();
            this.gb_text.ResumeLayout(false);
            this.gb_text.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_history_timeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_historycount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_verticalDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_fontsize)).EndInit();
            this.gb_background.ResumeLayout(false);
            this.gb_background.PerformLayout();
            this.gb_mouse.ResumeLayout(false);
            this.gb_mouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_ci_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_ci_opacity)).EndInit();
            this.gb_buttonindicator.ResumeLayout(false);
            this.gb_buttonindicator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_bi_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_bi_distance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_bi_size)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_align_left;
        private System.Windows.Forms.RadioButton rb_align_center;
        private System.Windows.Forms.RadioButton rb_align_right;
        private System.Windows.Forms.GroupBox gb_text_alignment;

        private System.Windows.Forms.RadioButton rb_td_up;
        private System.Windows.Forms.RadioButton rb_td_down;
        private System.Windows.Forms.GroupBox gb_textdir;

        private System.Windows.Forms.RadioButton rb_style_slide;
        private System.Windows.Forms.RadioButton rb_style_noani;
        private System.Windows.Forms.GroupBox gb_style;

        private System.Windows.Forms.Button button_textfont;
        private System.Windows.Forms.Label label_fontsize;
        private System.Windows.Forms.TrackBar slider_fontsize;
        private System.Windows.Forms.Label label_fontsize_display;
        private System.Windows.Forms.Button button_textcolor;
        private System.Windows.Forms.Label label_verticalDistance;
        private System.Windows.Forms.NumericUpDown nud_verticalDistance;
        private System.Windows.Forms.Label label_historycount;
        private System.Windows.Forms.CheckBox cb_enableHistoryTimeout;
        private System.Windows.Forms.NumericUpDown nud_historycount;
        private System.Windows.Forms.Label label_history_timeout;
        private System.Windows.Forms.TrackBar slider_history_timeout;
        private System.Windows.Forms.Label label_timeout_display;
        private System.Windows.Forms.CheckBox cb_backspace;
        private System.Windows.Forms.CheckBox cb_hideWindow;
        private System.Windows.Forms.GroupBox gb_text;

        private System.Windows.Forms.ColorDialog picker_textcolor;
        private System.Windows.Forms.FontDialog fontDialog_text;

        private System.Windows.Forms.CheckBox cb_cursorindicator;
        private System.Windows.Forms.Label label_ci_size;
        private System.Windows.Forms.TrackBar slider_ci_size;
        private System.Windows.Forms.Label label_ci_size_display;
        private System.Windows.Forms.Label label_ci_opacity;
        private System.Windows.Forms.TrackBar slider_ci_opacity;
        private System.Windows.Forms.Label label_ci_opacity_display;
        private System.Windows.Forms.Button button_ci_color;
        private System.Windows.Forms.GroupBox gb_mouse;

        private System.Windows.Forms.ColorDialog picker_ci_color;

        private System.Windows.Forms.Label label_opacity;
        private System.Windows.Forms.TrackBar slider_opacity;
        private System.Windows.Forms.Label label_opacity_display;
        private System.Windows.Forms.Button button_backcolor;
        private System.Windows.Forms.GroupBox gb_background;

        private System.Windows.Forms.ColorDialog picker_backcolor;

        private System.Windows.Forms.RadioButton rb_bi_icon;
        private System.Windows.Forms.RadioButton rb_bi_disable;
        private System.Windows.Forms.RadioButton rb_bi_simple;
        private System.Windows.Forms.Label label_bi_size;
        private System.Windows.Forms.TrackBar slider_bi_size;
        private System.Windows.Forms.Label label_bi_size_display;
        private System.Windows.Forms.Label label_bi_distance;
        private System.Windows.Forms.TrackBar slider_bi_distance;
        private System.Windows.Forms.Label label_bi_distance_display;
        private System.Windows.Forms.Label label_bi_angle;
        private System.Windows.Forms.TrackBar slider_bi_angle;
        private System.Windows.Forms.Label label_bi_angle_display;
        private System.Windows.Forms.CheckBox cb_bi_history;
        private System.Windows.Forms.GroupBox gb_buttonindicator;


        private System.Windows.Forms.Button bn_reset_position;
        private System.Windows.Forms.Button bn_reset_all;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_close;

        private System.Windows.Forms.ComboBox cmb_language;
    }
}