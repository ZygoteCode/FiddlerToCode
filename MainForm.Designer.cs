partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.siticoneControlBox2 = new ns1.SiticoneControlBox();
            this.siticoneControlBox1 = new ns1.SiticoneControlBox();
            this.siticoneShadowForm1 = new ns1.SiticoneShadowForm(this.components);
            this.siticoneTextBox4 = new ns1.SiticoneTextBox();
            this.gunaButton16 = new Guna.UI.WinForms.GunaButton();
            this.siticoneTextBox1 = new ns1.SiticoneTextBox();
            this.siticoneTextBox2 = new ns1.SiticoneTextBox();
            this.SuspendLayout();
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = ns5.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.siticoneControlBox2.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(176)))), ((int)(((byte)(68)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(386, 11);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 5;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(176)))), ((int)(((byte)(68)))));
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(431, 11);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 4;
            // 
            // siticoneTextBox4
            // 
            this.siticoneTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(176)))), ((int)(((byte)(68)))));
            this.siticoneTextBox4.BorderRadius = 3;
            this.siticoneTextBox4.BorderThickness = 3;
            this.siticoneTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox4.DefaultText = "";
            this.siticoneTextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox4.DisabledState.Parent = this.siticoneTextBox4;
            this.siticoneTextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.siticoneTextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(88)))), ((int)(((byte)(33)))));
            this.siticoneTextBox4.FocusedState.Parent = this.siticoneTextBox4;
            this.siticoneTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.siticoneTextBox4.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(131)))), ((int)(((byte)(51)))));
            this.siticoneTextBox4.HoveredState.Parent = this.siticoneTextBox4;
            this.siticoneTextBox4.Location = new System.Drawing.Point(17, 58);
            this.siticoneTextBox4.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.siticoneTextBox4.MaxLength = 3000;
            this.siticoneTextBox4.Multiline = true;
            this.siticoneTextBox4.Name = "siticoneTextBox4";
            this.siticoneTextBox4.PasswordChar = '\0';
            this.siticoneTextBox4.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.siticoneTextBox4.PlaceholderText = "Headers text in Fiddler";
            this.siticoneTextBox4.SelectedText = "";
            this.siticoneTextBox4.ShadowDecoration.Parent = this.siticoneTextBox4;
            this.siticoneTextBox4.Size = new System.Drawing.Size(447, 192);
            this.siticoneTextBox4.TabIndex = 8;
            // 
            // gunaButton16
            // 
            this.gunaButton16.Animated = true;
            this.gunaButton16.AnimationHoverSpeed = 0.07F;
            this.gunaButton16.AnimationSpeed = 0.03F;
            this.gunaButton16.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton16.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(176)))), ((int)(((byte)(68)))));
            this.gunaButton16.BorderColor = System.Drawing.Color.Transparent;
            this.gunaButton16.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton16.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton16.ForeColor = System.Drawing.Color.White;
            this.gunaButton16.Image = null;
            this.gunaButton16.ImageSize = new System.Drawing.Size(24, 24);
            this.gunaButton16.Location = new System.Drawing.Point(17, 363);
            this.gunaButton16.Name = "gunaButton16";
            this.gunaButton16.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(131)))), ((int)(((byte)(51)))));
            this.gunaButton16.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton16.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton16.OnHoverImage = null;
            this.gunaButton16.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton16.Size = new System.Drawing.Size(447, 42);
            this.gunaButton16.TabIndex = 23;
            this.gunaButton16.Text = "Convert Fiddler headers to your custom text";
            this.gunaButton16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton16.Click += new System.EventHandler(this.gunaButton16_Click);
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(176)))), ((int)(((byte)(68)))));
            this.siticoneTextBox1.BorderRadius = 3;
            this.siticoneTextBox1.BorderThickness = 3;
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(88)))), ((int)(((byte)(33)))));
            this.siticoneTextBox1.FocusedState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.siticoneTextBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(131)))), ((int)(((byte)(51)))));
            this.siticoneTextBox1.HoveredState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Location = new System.Drawing.Point(17, 418);
            this.siticoneTextBox1.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.siticoneTextBox1.MaxLength = 3000;
            this.siticoneTextBox1.Multiline = true;
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.siticoneTextBox1.PlaceholderText = "Custom implementation";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.ShadowDecoration.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Size = new System.Drawing.Size(447, 192);
            this.siticoneTextBox1.TabIndex = 24;
            // 
            // siticoneTextBox2
            // 
            this.siticoneTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(176)))), ((int)(((byte)(68)))));
            this.siticoneTextBox2.BorderRadius = 3;
            this.siticoneTextBox2.BorderThickness = 3;
            this.siticoneTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox2.DefaultText = "";
            this.siticoneTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox2.DisabledState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.siticoneTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(88)))), ((int)(((byte)(33)))));
            this.siticoneTextBox2.FocusedState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.siticoneTextBox2.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(131)))), ((int)(((byte)(51)))));
            this.siticoneTextBox2.HoveredState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.Location = new System.Drawing.Point(17, 256);
            this.siticoneTextBox2.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.siticoneTextBox2.MaxLength = 3000;
            this.siticoneTextBox2.Multiline = true;
            this.siticoneTextBox2.Name = "siticoneTextBox2";
            this.siticoneTextBox2.PasswordChar = '\0';
            this.siticoneTextBox2.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.siticoneTextBox2.PlaceholderText = "Custom text";
            this.siticoneTextBox2.SelectedText = "";
            this.siticoneTextBox2.ShadowDecoration.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.Size = new System.Drawing.Size(447, 94);
            this.siticoneTextBox2.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(486, 637);
            this.Controls.Add(this.siticoneTextBox2);
            this.Controls.Add(this.siticoneTextBox1);
            this.Controls.Add(this.gunaButton16);
            this.Controls.Add(this.siticoneTextBox4);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);

    }

    #endregion

    private ns1.SiticoneControlBox siticoneControlBox2;
    private ns1.SiticoneControlBox siticoneControlBox1;
    private ns1.SiticoneShadowForm siticoneShadowForm1;
    private ns1.SiticoneTextBox siticoneTextBox4;
    private Guna.UI.WinForms.GunaButton gunaButton16;
    private ns1.SiticoneTextBox siticoneTextBox1;
    private ns1.SiticoneTextBox siticoneTextBox2;
}