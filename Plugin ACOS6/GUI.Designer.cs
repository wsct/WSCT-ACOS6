namespace WSCT.GUI.Plugins.ACOS6
{
    partial class Gui
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripContainer toolStripContainer1;
            System.Windows.Forms.TextBox CC4ManagerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComputeShortKeyResultButton = new System.Windows.Forms.Button();
            this.CardChallengeValue = new System.Windows.Forms.TextBox();
            this.CardKeyValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CardRandomLabel = new System.Windows.Forms.Label();
            this.CardKeyLabel = new System.Windows.Forms.Label();
            this.ConfigurationZone = new System.Windows.Forms.GroupBox();
            this.CC4Manager = new System.Windows.Forms.CheckBox();
            this.ShortKeyAuthenticationValue = new System.Windows.Forms.TextBox();
            toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            CC4ManagerLabel = new System.Windows.Forms.TextBox();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ConfigurationZone.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(this.groupBox1);
            toolStripContainer1.ContentPanel.Controls.Add(this.ConfigurationZone);
            toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(778, 336);
            toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new System.Drawing.Size(778, 336);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.ShortKeyAuthenticationValue);
            this.groupBox1.Controls.Add(this.ComputeShortKeyResultButton);
            this.groupBox1.Controls.Add(this.CardChallengeValue);
            this.groupBox1.Controls.Add(this.CardKeyValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CardRandomLabel);
            this.groupBox1.Controls.Add(this.CardKeyLabel);
            this.groupBox1.Location = new System.Drawing.Point(18, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(754, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Short Key Authentication";
            // 
            // ComputeShortKeyResultButton
            // 
            this.ComputeShortKeyResultButton.Location = new System.Drawing.Point(11, 83);
            this.ComputeShortKeyResultButton.Name = "ComputeShortKeyResultButton";
            this.ComputeShortKeyResultButton.Size = new System.Drawing.Size(147, 34);
            this.ComputeShortKeyResultButton.TabIndex = 5;
            this.ComputeShortKeyResultButton.Text = "Compute Result";
            this.ComputeShortKeyResultButton.UseVisualStyleBackColor = true;
            this.ComputeShortKeyResultButton.Click += new System.EventHandler(this.ComputeShortKeyResultButton_Click);
            // 
            // CardChallengeValue
            // 
            this.CardChallengeValue.Font = new System.Drawing.Font("Fira Code", 7.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardChallengeValue.Location = new System.Drawing.Point(204, 50);
            this.CardChallengeValue.Name = "CardChallengeValue";
            this.CardChallengeValue.Size = new System.Drawing.Size(240, 27);
            this.CardChallengeValue.TabIndex = 4;
            this.CardChallengeValue.Text = "11 22 33 44";
            this.CardChallengeValue.TextChanged += new System.EventHandler(this.CardChallengeValue_TextChanged);
            // 
            // CardKeyValue
            // 
            this.CardKeyValue.Font = new System.Drawing.Font("Fira Code", 7.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardKeyValue.Location = new System.Drawing.Point(204, 18);
            this.CardKeyValue.Name = "CardKeyValue";
            this.CardKeyValue.Size = new System.Drawing.Size(543, 27);
            this.CardKeyValue.TabIndex = 3;
            this.CardKeyValue.Text = "11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF 00";
            this.CardKeyValue.TextChanged += new System.EventHandler(this.CardKeyValue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Authentication Value:";
            // 
            // CardRandomLabel
            // 
            this.CardRandomLabel.AutoSize = true;
            this.CardRandomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardRandomLabel.Location = new System.Drawing.Point(7, 53);
            this.CardRandomLabel.Name = "CardRandomLabel";
            this.CardRandomLabel.Size = new System.Drawing.Size(191, 20);
            this.CardRandomLabel.TabIndex = 1;
            this.CardRandomLabel.Text = "Card Random Number:";
            // 
            // CardKeyLabel
            // 
            this.CardKeyLabel.AutoSize = true;
            this.CardKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardKeyLabel.Location = new System.Drawing.Point(7, 24);
            this.CardKeyLabel.Name = "CardKeyLabel";
            this.CardKeyLabel.Size = new System.Drawing.Size(150, 20);
            this.CardKeyLabel.TabIndex = 0;
            this.CardKeyLabel.Text = "Card Key (3DES):";
            // 
            // ConfigurationZone
            // 
            this.ConfigurationZone.AutoSize = true;
            this.ConfigurationZone.Controls.Add(CC4ManagerLabel);
            this.ConfigurationZone.Controls.Add(this.CC4Manager);
            this.ConfigurationZone.Location = new System.Drawing.Point(18, 18);
            this.ConfigurationZone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConfigurationZone.Name = "ConfigurationZone";
            this.ConfigurationZone.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConfigurationZone.Size = new System.Drawing.Size(747, 117);
            this.ConfigurationZone.TabIndex = 1;
            this.ConfigurationZone.TabStop = false;
            this.ConfigurationZone.Text = "Stack Configuration";
            // 
            // CC4ManagerLabel
            // 
            CC4ManagerLabel.BackColor = System.Drawing.SystemColors.Control;
            CC4ManagerLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            CC4ManagerLabel.Location = new System.Drawing.Point(9, 65);
            CC4ManagerLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            CC4ManagerLabel.Multiline = true;
            CC4ManagerLabel.Name = "CC4ManagerLabel";
            CC4ManagerLabel.Size = new System.Drawing.Size(530, 23);
            CC4ManagerLabel.TabIndex = 1;
            CC4ManagerLabel.Text = "▷ allows to execute SELECT command as a CC4.";
            // 
            // CC4Manager
            // 
            this.CC4Manager.AutoSize = true;
            this.CC4Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC4Manager.Location = new System.Drawing.Point(9, 29);
            this.CC4Manager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CC4Manager.Name = "CC4Manager";
            this.CC4Manager.Size = new System.Drawing.Size(149, 24);
            this.CC4Manager.TabIndex = 0;
            this.CC4Manager.Text = "CC4 Manager";
            this.CC4Manager.UseVisualStyleBackColor = true;
            this.CC4Manager.CheckedChanged += new System.EventHandler(this.CC4Manager_CheckedChanged);
            // 
            // ShortKeyAuthenticationValue
            // 
            this.ShortKeyAuthenticationValue.Font = new System.Drawing.Font("Fira Code", 7.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortKeyAuthenticationValue.Location = new System.Drawing.Point(204, 123);
            this.ShortKeyAuthenticationValue.Name = "ShortKeyAuthenticationValue";
            this.ShortKeyAuthenticationValue.ReadOnly = true;
            this.ShortKeyAuthenticationValue.Size = new System.Drawing.Size(240, 27);
            this.ShortKeyAuthenticationValue.TabIndex = 6;
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(778, 336);
            this.Controls.Add(toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Gui";
            this.Text = "ACOS6 Smartcards for ENSICAEN";
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ConfigurationZone.ResumeLayout(false);
            this.ConfigurationZone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ConfigurationZone;
        private System.Windows.Forms.CheckBox CC4Manager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CardRandomLabel;
        private System.Windows.Forms.Label CardKeyLabel;
        private System.Windows.Forms.TextBox CardChallengeValue;
        private System.Windows.Forms.TextBox CardKeyValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ComputeShortKeyResultButton;
        private System.Windows.Forms.TextBox ShortKeyAuthenticationValue;
    }
}