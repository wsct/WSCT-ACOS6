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
            this.ConfigurationZone = new System.Windows.Forms.GroupBox();
            this.CC4Manager = new System.Windows.Forms.CheckBox();
            toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            CC4ManagerLabel = new System.Windows.Forms.TextBox();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            this.ConfigurationZone.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(this.ConfigurationZone);
            toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(584, 315);
            toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new System.Drawing.Size(584, 315);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            toolStripContainer1.TopToolStripPanelVisible = false;
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
            this.ConfigurationZone.Size = new System.Drawing.Size(548, 285);
            this.ConfigurationZone.TabIndex = 1;
            this.ConfigurationZone.TabStop = false;
            this.ConfigurationZone.Text = "ACOS6 Stack Configuration";
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
            CC4ManagerLabel.Text = "-> allows to execute SELECT command as a CC4.";
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
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 315);
            this.Controls.Add(toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Gui";
            this.Text = "ACOS6 Smartcards for ENSICAEN";
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            this.ConfigurationZone.ResumeLayout(false);
            this.ConfigurationZone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ConfigurationZone;
        private System.Windows.Forms.CheckBox CC4Manager;
    }
}