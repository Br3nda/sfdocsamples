namespace Health.Front
{
    partial class frmBase_Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase_Dialog));
            this.SuspendLayout();
            // 
            // aceptCancelButtonBar1
            // 
            this.aceptCancelButtonBar1.AceptButtonVisible = true;
            this.aceptCancelButtonBar1.BottomsVisible = true;
            this.aceptCancelButtonBar1.CancelButtonVisible = true;
            this.aceptCancelButtonBar1.Location = new System.Drawing.Point(3, 560);
            this.aceptCancelButtonBar1.Size = new System.Drawing.Size(1088, 28);
            // 
            // MessageViewer
            // 
            this.MessageViewer.IconSize = Fwk.UI.Common.IconSize.Large;
            this.MessageViewer.Title = "Hemosoft";
            // 
            // ExceptionViewer
            // 
            this.ExceptionViewer.Title = "Health 32";
            // 
            // frmBase_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 593);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBase_Dialog";
            this.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Text = "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBase_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBase_Dialog_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion




    }
}