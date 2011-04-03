using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quartz
{
    public partial class BalanceInfo : Form
    {
        public BalanceInfo()
        {
            InitializeComponent();
        }

        private void bandIDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bandIDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quartzDataDataSet);

        }

        private void BalanceInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quartzDataDataSet.SongID' table. You can move, or remove it, as needed.
            this.songIDTableAdapter.Fill(this.quartzDataDataSet.SongID);
            // TODO: This line of code loads data into the 'quartzDataDataSet.PaymentID' table. You can move, or remove it, as needed.
            this.paymentIDTableAdapter.Fill(this.quartzDataDataSet.PaymentID);
            // TODO: This line of code loads data into the 'quartzDataDataSet.BandID' table. You can move, or remove it, as needed.
            this.bandIDTableAdapter.Fill(this.quartzDataDataSet.BandID);

        }
    }
}
