using dotNet_GK_QUANLYTHUEXEOTO.Model.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNet_GK_QUANLYTHUEXEOTO.UserControls
{
    public partial class UC_CarTypeSelection : UserControl
    {
        public UC_CarTypeSelection()
        {
            InitializeComponent();
            pnMini.MouseEnter += Panel_MouseEnter;
            pnMini.MouseLeave += Panel_MouseLeave;

            pnCUV.MouseEnter += Panel_MouseEnter;
            pnCUV.MouseLeave += Panel_MouseLeave;

            pnHatchback.MouseEnter += Panel_MouseEnter;
            pnHatchback.MouseLeave += Panel_MouseLeave;

            pnMPV.MouseEnter += Panel_MouseEnter;
            pnMPV.MouseLeave += Panel_MouseLeave;

            pnSUV.MouseEnter += Panel_MouseEnter;
            pnSUV.MouseLeave += Panel_MouseLeave;

            pnSedan.MouseEnter += Panel_MouseEnter;
            pnSedan.MouseLeave += Panel_MouseLeave;

            pnPickup.MouseEnter += Panel_MouseEnter;
            pnPickup.MouseLeave += Panel_MouseLeave;
        }
        private void addUserControl(UserControl userControl, Control panel)
        {
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void pnCar_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;

            if (clickedPanel != null && clickedPanel.Parent != null)
            {
                GroupBox grpbox = clickedPanel.Parent as GroupBox;
                if (grpbox != null && grpbox.Parent != null)
                {
                    UserControl userControl = grpbox.Parent as UserControl;

                    if (userControl != null && userControl.Parent != null)
                    {
                        Panel panelContaner = userControl.Parent as Panel;
                        if (panelContaner != null)
                        {
                            UC_RentCar uc = new UC_RentCar();
                            Label foundLabel = null;
                            foreach (Control control in clickedPanel.Controls)
                            {
                                if (control is Label)
                                {
                                    foundLabel = (Label)control;
                                    break;
                                }
                            }
                            uc.CarType = foundLabel.Text;
                            addUserControl(uc, panelContaner);
                        }
                    }
                }
            }
        }
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                panel.BackColor = Color.RosyBrown;
            }
        }
        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                panel.BackColor = Color.Transparent;
            }
        }
    }
}
