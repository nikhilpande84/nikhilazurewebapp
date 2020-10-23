using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HighAmbitionSoftwareTechnologiesAndComputerCoaching;

namespace HighAmbitionSoftwareTechnologiesAndComputerCoaching
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            blttxtServicesProvided.Visible = false;
            txtContact.Visible = false;
            txtCompanyHistory.Visible = false;
            txtCompanyValues.Visible = false;
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            //Site1 masterSite = new Site1();
            if (Menu_Logo.SelectedItem.Text.ToString().Contains("Provided"))
            {
                blttxtServicesProvided.Visible = true;
                txtContact.Visible = false;
                txtCompanyHistory.Visible = false;
                txtCompanyValues.Visible = false;
            }
            if (Menu_Logo.SelectedItem.Text.ToString().Contains("History"))
            {
                blttxtServicesProvided.Visible = false;
                txtContact.Visible = false;
                txtCompanyHistory.Visible = true;
                txtCompanyValues.Visible = false;
            }
            if (Menu_Logo.SelectedItem.Text.ToString().Contains("Values"))
            {
                blttxtServicesProvided.Visible = false;
                txtContact.Visible = false;
                txtCompanyHistory.Visible = false;
                txtCompanyValues.Visible = true;
            }
            if (Menu_Logo.SelectedItem.Text.ToString().Contains("Contact"))
            {
                blttxtServicesProvided.Visible = false;
                txtContact.Visible = true;
                txtCompanyHistory.Visible = false;
                txtCompanyValues.Visible = false;
            }
        }
    }
}