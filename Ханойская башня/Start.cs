using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ханойская_башня
{
	public partial class Start : MaterialForm
	{
		public Start()
		{
			InitializeComponent();
		}

		private void materialButton1_Click(object sender, EventArgs e)
		{
			App a = new App();
			a.Show();
			Hide();
		}
	}
}
