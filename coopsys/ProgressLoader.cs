using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coopsys
{
    public partial class ProgressLoader : Form
    {
        public Action worker { get; set; }

        public ProgressLoader(Action _worker)
        {
            InitializeComponent();
            if (_worker == null)
                throw new ArgumentNullException();
            worker = _worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(worker).ContinueWith(task => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
