namespace AutoParts.UserForm
{
    partial class TableForm
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
            tableControl1 = new Controls.TableControl();
            SuspendLayout();
            // 
            // tableControl1
            // 
            tableControl1.Location = new Point(36, 30);
            tableControl1.Name = "tableControl1";
            tableControl1.Size = new Size(1012, 515);
            tableControl1.TabIndex = 0;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 602);
            Controls.Add(tableControl1);
            Name = "TableForm";
            Text = "TableForm";
            ResumeLayout(false);
        }

        #endregion

        private Controls.TableControl tableControl1;
    }
}