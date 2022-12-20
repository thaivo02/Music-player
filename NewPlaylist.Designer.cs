namespace Muzic
{
    partial class NewPlaylist
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
            this.txtPlaylist_name = new System.Windows.Forms.TextBox();
            this.btnPlaylist_create = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // txtPlaylist_name
            // 
            this.txtPlaylist_name.BackColor = System.Drawing.Color.Lavender;
            this.txtPlaylist_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlaylist_name.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlaylist_name.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPlaylist_name.Location = new System.Drawing.Point(22, 12);
            this.txtPlaylist_name.Name = "txtPlaylist_name";
            this.txtPlaylist_name.PlaceholderText = "Playlist\'s name";
            this.txtPlaylist_name.Size = new System.Drawing.Size(267, 40);
            this.txtPlaylist_name.TabIndex = 0;
            // 
            // btnPlaylist_create
            // 
            this.btnPlaylist_create.BorderRadius = 10;
            this.btnPlaylist_create.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPlaylist_create.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPlaylist_create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaylist_create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaylist_create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlaylist_create.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlaylist_create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlaylist_create.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlaylist_create.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPlaylist_create.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnPlaylist_create.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPlaylist_create.HoverState.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlaylist_create.Location = new System.Drawing.Point(43, 106);
            this.btnPlaylist_create.Name = "btnPlaylist_create";
            this.btnPlaylist_create.PressedColor = System.Drawing.Color.AliceBlue;
            this.btnPlaylist_create.Size = new System.Drawing.Size(225, 41);
            this.btnPlaylist_create.TabIndex = 3;
            this.btnPlaylist_create.Text = "Create";
            this.btnPlaylist_create.Click += new System.EventHandler(this.btnPlaylist_create_Click);
            // 
            // NewPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(311, 253);
            this.Controls.Add(this.btnPlaylist_create);
            this.Controls.Add(this.txtPlaylist_name);
            this.Name = "NewPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPlaylist_name;
        private Guna.UI2.WinForms.Guna2GradientButton btnPlaylist_create;
    }
}