﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSDropAssist.Settings
{
   
    public partial class VSDropAssistPopupControl : UserControl
    {
        public class SettingUpdateEventArgs : EventArgs
        {
            public DropActionConfiguration SelectedSetting { get; private set; }
            public string Example { get; set; }
            public string VariableName { get; private set; }
            public SettingUpdateEventArgs(DropActionConfiguration selectedSetting, string variableName) : base()
            {
                VariableName = variableName;
                Example = string.Empty;
                SelectedSetting = selectedSetting;
            }
        }

        public EventHandler<SettingUpdateEventArgs> OnSettingUpdate;
         
        public VSDropAssistPopupControl()
        {
            InitializeComponent();
        }

        private void OptionKeyControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bindingSource1.Position = this.OptionKeyControl.SelectedIndex;

        }
        
        public VSDropSettings Data
        {
            get { return (VSDropSettings)this.bindingSource1.DataSource; } 
            set { this.bindingSource1.DataSource = value; }
        }

        public DropActionConfiguration SelectedItem
        {
            get
            {
                return (DropActionConfiguration) this.bindingSource1.Current;
                
            }
        }

        public string VariableName {  get { return this.variableNameControl.Text; } }
public string FormatExpression {  get { return this.FormatExpressionControl.Text; } }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            // update the example data

            refreshExample();
        }

        private void refreshExample()
        {
           throw new NotImplementedException();
        }

        private void variableNameControl_TextChanged(object sender, EventArgs e)
        {
            refreshExample();
        }
    }
}
