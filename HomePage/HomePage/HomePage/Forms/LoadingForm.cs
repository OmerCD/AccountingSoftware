using System;
using System.Windows.Forms;

namespace HomePage.Forms
{
    public partial class LoadingForm : Form
    {
        public event Action ClosedBeforeFinished;
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_KeyDown(object sender, KeyEventArgs e) //todo: Will be used for user cancellation on waiting screen
        {
            if (e.KeyCode==Keys.Escape)
            {
                //Close();
                ClosedBeforeFinished?.Invoke();
            }
        }
    }
}
