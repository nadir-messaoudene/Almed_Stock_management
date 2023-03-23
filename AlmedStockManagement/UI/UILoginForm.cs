using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmedStockManagement
{
    public partial class UILoginForm : Form, ISubject
    {

        private List<IObserver> observers = new List<IObserver>();
        public UILoginForm()
        {
            InitializeComponent();
        }

        private void TestConnexioSimpleButton_Click(object sender, EventArgs e)
        {
            Notify(true);
        }

        private void CuncelSimpleButton_Click(object sender, EventArgs e) => Close();

        public void Subscribe(IObserver observer) => observers.Add(observer);

        public void Unsubscribe(IObserver observer) => observers.Remove(observer);

        public void Notify(bool ctr) => observers.ForEach(x => x.Update(ctr));

        private void UILoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
