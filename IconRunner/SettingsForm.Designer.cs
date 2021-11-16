
namespace IconRunner
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.themeSelectGroup = new System.Windows.Forms.GroupBox();
            this.scaleValue = new System.Windows.Forms.MaskedTextBox();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.iconVariantValue = new System.Windows.Forms.ComboBox();
            this.iconPackValue = new System.Windows.Forms.ComboBox();
            this.iconVariantLabel = new System.Windows.Forms.Label();
            this.iconPackLabel = new System.Windows.Forms.Label();
            this.micsLabel = new System.Windows.Forms.GroupBox();
            this.constantSpeedCheck = new System.Windows.Forms.CheckBox();
            this.startupCheck = new System.Windows.Forms.CheckBox();
            this.saveSettingsButtion = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.themeSelectGroup.SuspendLayout();
            this.micsLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // themeSelectGroup
            // 
            this.themeSelectGroup.Controls.Add(this.scaleValue);
            this.themeSelectGroup.Controls.Add(this.scaleLabel);
            this.themeSelectGroup.Controls.Add(this.iconVariantValue);
            this.themeSelectGroup.Controls.Add(this.iconPackValue);
            this.themeSelectGroup.Controls.Add(this.iconVariantLabel);
            this.themeSelectGroup.Controls.Add(this.iconPackLabel);
            this.themeSelectGroup.Location = new System.Drawing.Point(13, 13);
            this.themeSelectGroup.Name = "themeSelectGroup";
            this.themeSelectGroup.Size = new System.Drawing.Size(223, 108);
            this.themeSelectGroup.TabIndex = 0;
            this.themeSelectGroup.TabStop = false;
            this.themeSelectGroup.Text = "Theme selector";
            // 
            // scaleValue
            // 
            this.scaleValue.Location = new System.Drawing.Point(93, 73);
            this.scaleValue.Mask = "00000";
            this.scaleValue.Name = "scaleValue";
            this.scaleValue.Size = new System.Drawing.Size(121, 20);
            this.scaleValue.TabIndex = 5;
            this.scaleValue.ValidatingType = typeof(int);
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Location = new System.Drawing.Point(4, 76);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(83, 13);
            this.scaleLabel.TabIndex = 4;
            this.scaleLabel.Text = "Animation Scale";
            this.scaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iconVariantValue
            // 
            this.iconVariantValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iconVariantValue.FormattingEnabled = true;
            this.iconVariantValue.Items.AddRange(new object[] {
            "default",
            "dark",
            "light"});
            this.iconVariantValue.Location = new System.Drawing.Point(93, 45);
            this.iconVariantValue.Name = "iconVariantValue";
            this.iconVariantValue.Size = new System.Drawing.Size(121, 21);
            this.iconVariantValue.TabIndex = 3;
            // 
            // iconPackValue
            // 
            this.iconPackValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iconPackValue.FormattingEnabled = true;
            this.iconPackValue.Items.AddRange(new object[] {
            "bbballele",
            "bbbele",
            "bbbfus",
            "cat",
            "parrot"});
            this.iconPackValue.Location = new System.Drawing.Point(93, 18);
            this.iconPackValue.Name = "iconPackValue";
            this.iconPackValue.Size = new System.Drawing.Size(121, 21);
            this.iconPackValue.TabIndex = 2;
            // 
            // iconVariantLabel
            // 
            this.iconVariantLabel.AutoSize = true;
            this.iconVariantLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconVariantLabel.Location = new System.Drawing.Point(47, 48);
            this.iconVariantLabel.Name = "iconVariantLabel";
            this.iconVariantLabel.Size = new System.Drawing.Size(40, 13);
            this.iconVariantLabel.TabIndex = 1;
            this.iconVariantLabel.Text = "Variant";
            // 
            // iconPackLabel
            // 
            this.iconPackLabel.AutoSize = true;
            this.iconPackLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconPackLabel.Location = new System.Drawing.Point(32, 21);
            this.iconPackLabel.Name = "iconPackLabel";
            this.iconPackLabel.Size = new System.Drawing.Size(55, 13);
            this.iconPackLabel.TabIndex = 0;
            this.iconPackLabel.Text = "Icon pack";
            // 
            // micsLabel
            // 
            this.micsLabel.Controls.Add(this.constantSpeedCheck);
            this.micsLabel.Controls.Add(this.startupCheck);
            this.micsLabel.Location = new System.Drawing.Point(13, 127);
            this.micsLabel.Name = "micsLabel";
            this.micsLabel.Size = new System.Drawing.Size(223, 70);
            this.micsLabel.TabIndex = 1;
            this.micsLabel.TabStop = false;
            this.micsLabel.Text = "Other settings";
            // 
            // constantSpeedCheck
            // 
            this.constantSpeedCheck.AutoSize = true;
            this.constantSpeedCheck.Location = new System.Drawing.Point(7, 43);
            this.constantSpeedCheck.Name = "constantSpeedCheck";
            this.constantSpeedCheck.Size = new System.Drawing.Size(148, 17);
            this.constantSpeedCheck.TabIndex = 1;
            this.constantSpeedCheck.Text = "Constant animation speed";
            this.constantSpeedCheck.UseVisualStyleBackColor = true;
            // 
            // startupCheck
            // 
            this.startupCheck.AutoSize = true;
            this.startupCheck.Location = new System.Drawing.Point(7, 20);
            this.startupCheck.Name = "startupCheck";
            this.startupCheck.Size = new System.Drawing.Size(93, 17);
            this.startupCheck.TabIndex = 0;
            this.startupCheck.Text = "Run at startup";
            this.startupCheck.UseVisualStyleBackColor = true;
            // 
            // saveSettingsButtion
            // 
            this.saveSettingsButtion.Location = new System.Drawing.Point(161, 203);
            this.saveSettingsButtion.Name = "saveSettingsButtion";
            this.saveSettingsButtion.Size = new System.Drawing.Size(75, 23);
            this.saveSettingsButtion.TabIndex = 2;
            this.saveSettingsButtion.Text = "Save";
            this.saveSettingsButtion.UseVisualStyleBackColor = true;
            this.saveSettingsButtion.Click += new System.EventHandler(this.saveSettingsButtion_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(80, 203);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 233);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.saveSettingsButtion);
            this.Controls.Add(this.micsLabel);
            this.Controls.Add(this.themeSelectGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.themeSelectGroup.ResumeLayout(false);
            this.themeSelectGroup.PerformLayout();
            this.micsLabel.ResumeLayout(false);
            this.micsLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox themeSelectGroup;
        private System.Windows.Forms.ComboBox iconVariantValue;
        private System.Windows.Forms.ComboBox iconPackValue;
        private System.Windows.Forms.Label iconVariantLabel;
        private System.Windows.Forms.Label iconPackLabel;
        private System.Windows.Forms.MaskedTextBox scaleValue;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.GroupBox micsLabel;
        private System.Windows.Forms.CheckBox startupCheck;
        private System.Windows.Forms.CheckBox constantSpeedCheck;
        private System.Windows.Forms.Button saveSettingsButtion;
        private System.Windows.Forms.Button resetButton;
    }
}