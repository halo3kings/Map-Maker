namespace WindowsFormsApp2
{
    partial class MapProgress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Events = new System.Windows.Forms.GroupBox();
            this.MessageBody = new System.Windows.Forms.TableLayoutPanel();
            this.text = new System.Windows.Forms.Label();
            this.Events.SuspendLayout();
            this.MessageBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 52);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(358, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // Events
            // 
            this.Events.Controls.Add(this.MessageBody);
            this.Events.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Events.Location = new System.Drawing.Point(0, 0);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(358, 52);
            this.Events.TabIndex = 1;
            this.Events.TabStop = false;
            this.Events.Text = "Events";
            // 
            // MessageBody
            // 
            this.MessageBody.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MessageBody.ColumnCount = 1;
            this.MessageBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MessageBody.Controls.Add(this.text, 0, 0);
            this.MessageBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageBody.Location = new System.Drawing.Point(3, 16);
            this.MessageBody.Name = "MessageBody";
            this.MessageBody.RowCount = 1;
            this.MessageBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.MessageBody.Size = new System.Drawing.Size(352, 33);
            this.MessageBody.TabIndex = 0;
            this.MessageBody.Paint += new System.Windows.Forms.PaintEventHandler(this.MessageBody_Paint);
            // 
            // text
            // 
            this.text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(3, 10);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(0, 13);
            this.text.TabIndex = 0;
            this.text.Text = "Message";
            // 
            // MapProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 75);
            this.Controls.Add(this.Events);
            this.Controls.Add(this.progressBar1);
            this.Name = "MapProgress";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MapProgress_Load);
            this.Events.ResumeLayout(false);
            this.MessageBody.ResumeLayout(false);
            this.MessageBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.GroupBox Events;
        public System.Windows.Forms.TableLayoutPanel MessageBody;
        public System.Windows.Forms.Label text;
    }
}