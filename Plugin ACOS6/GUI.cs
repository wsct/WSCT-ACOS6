using System;
using System.Windows.Forms;
using WSCT.ACOS6.Security.TripleDes;
using WSCT.GUI.Common.Resources.Helpers;
using WSCT.Helpers;
using WSCT.Layers.ACOS6;

namespace WSCT.GUI.Plugins.ACOS6
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Gui : Form
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public Gui()
        {
            InitializeComponent();

            CC4Manager.Checked = ACOS6Controller.UseCC4Manager;
        }

        #region >> *_Changed

        private void CC4Manager_CheckedChanged(object sender, EventArgs e)
        {
            ACOS6Controller.UseCC4Manager = CC4Manager.Checked;
        }

        #endregion

        #region >> *Click

        private void ComputeShortKeyResultButton_Click(object sender, EventArgs e)
        {
            var shortKey = CardKeyValue.Text.FromHexa();
            var challenge = CardChallengeValue.Text.FromHexa();

            ShortKeyAuthenticationValue.Text = challenge.Create3DESShortAuthenticationData(shortKey).ToHexa(' ');
        }

        #endregion

        #region >> *TextChanged

        private void CardKeyValue_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            try
            {
                var shortKey = textBox.Text.FromHexa();

                if (shortKey.Length != 16)
                {
                    textBox.SetControlBackColor(Common.Resources.Colors.StatusError);
                }
                else
                {
                    textBox.ResetControlBackColor();
                }
            }
            catch (Exception)
            {
                textBox.SetControlBackColor(Common.Resources.Colors.StatusError);
            }
        }

        private void CardChallengeValue_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            try
            {
                var challenge = textBox.Text.FromHexa();

                if (challenge.Length != 4)
                {
                    textBox.SetControlBackColor(Common.Resources.Colors.StatusError);
                }
                else
                {
                    textBox.ResetControlBackColor();
                }
            }
            catch (Exception)
            {
                textBox.SetControlBackColor(Common.Resources.Colors.StatusError);
            }
        }

        #endregion
    }
}