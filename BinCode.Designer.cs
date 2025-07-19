namespace BinCode
{
    partial class Bincode
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bincode));
            Title = new Label();
            Painel = new Panel();
            Converter = new Button();
            To = new Label();
            Select2 = new ComboBox();
            Select1 = new ComboBox();
            Output = new TextBox();
            Input = new TextBox();
            Painel.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(260, 28);
            Title.Name = "Title";
            Title.Size = new Size(166, 25);
            Title.TabIndex = 0;
            Title.Text = "Tradutor Binario";
            // 
            // Painel
            // 
            Painel.Controls.Add(Converter);
            Painel.Controls.Add(To);
            Painel.Controls.Add(Select2);
            Painel.Controls.Add(Select1);
            Painel.Controls.Add(Output);
            Painel.Controls.Add(Input);
            Painel.Location = new Point(12, 85);
            Painel.Name = "Painel";
            Painel.Size = new Size(662, 293);
            Painel.TabIndex = 1;
            // 
            // Converter
            // 
            Converter.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Converter.Image = (Image)resources.GetObject("Converter.Image");
            Converter.ImageAlign = ContentAlignment.MiddleLeft;
            Converter.Location = new Point(276, 250);
            Converter.Name = "Converter";
            Converter.Size = new Size(111, 30);
            Converter.TabIndex = 2;
            Converter.Text = "Converter ";
            Converter.TextAlign = ContentAlignment.MiddleRight;
            Converter.TextImageRelation = TextImageRelation.TextBeforeImage;
            Converter.UseVisualStyleBackColor = true;
            Converter.Click += Converter_Click;
            // 
            // To
            // 
            To.AutoSize = true;
            To.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            To.Location = new Point(314, 18);
            To.Name = "To";
            To.Size = new Size(35, 17);
            To.TabIndex = 5;
            To.Text = "Para";
            // 
            // Select2
            // 
            Select2.DisplayMember = "Texto";
            Select2.DropDownStyle = ComboBoxStyle.DropDownList;
            Select2.Font = new Font("Microsoft Sans Serif", 9.75F);
            Select2.FormattingEnabled = true;
            Select2.ItemHeight = 16;
            Select2.Items.AddRange(new object[] { "Binario", "Texto" });
            Select2.SelectedIndex = 0;
            Select2.Location = new Point(355, 14);
            Select2.Name = "Select2";
            Select2.Size = new Size(113, 24);
            Select2.TabIndex = 4;
            Select2.Tag = "";
            // 
            // Select1
            // 
            Select1.DisplayMember = "Texto";
            Select1.DropDownStyle = ComboBoxStyle.DropDownList;
            Select1.Font = new Font("Microsoft Sans Serif", 9.75F);
            Select1.FormattingEnabled = true;
            Select1.ItemHeight = 16;
            Select1.Items.AddRange(new object[] { "Binario", "Texto" });
            Select1.SelectedIndex = 1;
            Select1.Location = new Point(194, 14);
            Select1.Name = "Select1";
            Select1.Size = new Size(113, 24);
            Select1.TabIndex = 3;
            Select1.Tag = "";
            Select1.SelectedValueChanged += Select1_SelectedValueChanged;
            // 
            // Output
            // 
            Output.Font = new Font("Microsoft Sans Serif", 9.75F);
            Output.Location = new Point(348, 54);
            Output.Multiline = true;
            Output.Name = "Output";
            Output.PlaceholderText = "Saída...";
            Output.Size = new Size(254, 174);
            Output.TabIndex = 1;
            Output.KeyPress += Output_KeyPress;
            // 
            // Input
            // 
            Input.Font = new Font("Microsoft Sans Serif", 9.75F);
            Input.Location = new Point(61, 54);
            Input.Multiline = true;
            Input.Name = "Input";
            Input.PlaceholderText = "Entrada...";
            Input.Size = new Size(254, 174);
            Input.TabIndex = 0;
            Input.KeyPress += Input_KeyPress;
            // 
            // Bincode
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(686, 390);
            Controls.Add(Painel);
            Controls.Add(Title);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(702, 429);
            MinimumSize = new Size(702, 429);
            Name = "Bincode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BinCode";
            Painel.ResumeLayout(false);
            Painel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Panel Painel;
        private TextBox Output;
        private TextBox Input;
        private ComboBox Select1;
        private ComboBox Select2;
        private Label To;
        private Button Converter;
    }
}
