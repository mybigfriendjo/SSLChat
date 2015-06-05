namespace SecureChatServer {
	partial class frmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
			this.textInput = new System.Windows.Forms.TextBox();
			this.buttonSend = new System.Windows.Forms.Button();
			this.richTextHistory = new System.Windows.Forms.RichTextBox();
			this.tableLayoutMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutMain
			// 
			this.tableLayoutMain.ColumnCount = 2;
			this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutMain.Controls.Add(this.textInput, 0, 1);
			this.tableLayoutMain.Controls.Add(this.buttonSend, 1, 1);
			this.tableLayoutMain.Controls.Add(this.richTextHistory, 0, 0);
			this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutMain.Name = "tableLayoutMain";
			this.tableLayoutMain.RowCount = 2;
			this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutMain.Size = new System.Drawing.Size(683, 482);
			this.tableLayoutMain.TabIndex = 0;
			// 
			// textInput
			// 
			this.textInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textInput.Location = new System.Drawing.Point(3, 425);
			this.textInput.Multiline = true;
			this.textInput.Name = "textInput";
			this.textInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textInput.Size = new System.Drawing.Size(577, 54);
			this.textInput.TabIndex = 1;
			// 
			// buttonSend
			// 
			this.buttonSend.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonSend.Location = new System.Drawing.Point(586, 425);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(94, 54);
			this.buttonSend.TabIndex = 2;
			this.buttonSend.Text = "Send";
			this.buttonSend.UseVisualStyleBackColor = true;
			// 
			// richTextHistory
			// 
			this.tableLayoutMain.SetColumnSpan(this.richTextHistory, 2);
			this.richTextHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextHistory.Location = new System.Drawing.Point(3, 3);
			this.richTextHistory.Name = "richTextHistory";
			this.richTextHistory.ReadOnly = true;
			this.richTextHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.richTextHistory.Size = new System.Drawing.Size(677, 416);
			this.richTextHistory.TabIndex = 3;
			this.richTextHistory.Text = "";
			// 
			// frmMain
			// 
			this.AcceptButton = this.buttonSend;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(683, 482);
			this.Controls.Add(this.tableLayoutMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.Text = "Secure Chat Server";
			this.tableLayoutMain.ResumeLayout(false);
			this.tableLayoutMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
		private System.Windows.Forms.TextBox textInput;
		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.RichTextBox richTextHistory;
	}
}

