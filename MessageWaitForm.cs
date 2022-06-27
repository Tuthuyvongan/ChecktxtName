using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecktxtName
{
    public partial class MessageWaitForm : Form
    {
        public MessageWaitForm()
        {
            InitializeComponent();
        }
        public void UpdateProgress(int progress, string announce)
        {
            lbProg.BeginInvoke(
                new Action(() =>
                {
                    lbProg.Text = announce + progress + "%";
                }));
            progressBar.BeginInvoke(
                new Action(() =>
                {
                    progressBar.Value = progress;
                }
            ));
        }
    }
}
