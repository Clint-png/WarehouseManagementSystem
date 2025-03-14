﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using warehousesystem.Models;

namespace warehousesystem.Forms
{
    public partial class Register : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void simpleButtonSignUp_Click(object sender, EventArgs e)
        {
            AdminRegister adminRegister = new AdminRegister();
            adminRegister.EmployeeID = textEditEmployeeID.Text;
            adminRegister.Username = textEditUsername.Text;
            adminRegister.Password = textEditPassword.Text;

           // RegisterAdmin(adminRegister);

        }

        private void RegisterAdmin()
        {

        }
    }
}