using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DITest
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IContainer container = new Container();

            container.SetLogger(new Logger());

            this.BusinessLogic(container);

        }

        public void BusinessLogic(IContainer container)
        {
            ILogger logger = container.GetLogger();
            logger.Write("ログを表示します");
        }
    }
}
