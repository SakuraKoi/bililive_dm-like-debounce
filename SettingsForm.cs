using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bililive_dm_like_debounce {
    public partial class SettingsForm : Form {
        public SettingsForm() {
            InitializeComponent();
            inputFreq.Value = Properties.Settings.Default.frequency;
            var mode = Properties.Settings.Default.intervalMode;
            if (mode) {
                selectInterval.Checked = true;
                selectFreq.Checked = false;
            } else {
                selectFreq.Checked = true;
                selectInterval.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            Properties.Settings.Default.frequency = (int) inputFreq.Value;
            Properties.Settings.Default.intervalMode = selectInterval.Checked;
            Properties.Settings.Default.Save();

            Debouncer.frequency = Properties.Settings.Default.frequency;
            Debouncer.intervalMode = Properties.Settings.Default.intervalMode;

            MessageBox.Show("Configuration applied & saved", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Debouncer.reset();
            MessageBox.Show("ok", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}