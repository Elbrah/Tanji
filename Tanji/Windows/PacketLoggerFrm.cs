﻿using System;
using System.ComponentModel;

using Tanji.Controls;
using Tanji.Services;

using Sulakore.Network;

namespace Tanji.Windows
{
    [DesignerCategory("Form")]
    public partial class PacketLoggerFrm : ObservableForm, IHaltable, IReceiver
    {
        private readonly MainFrm _main;

        public bool IsAlwaysOnTop
        {
            get => TopMost;
            set
            {
                TopMost = value;
                _main.TopMost = value;
                RaiseOnPropertyChanged();
            }
        }

        public PacketLoggerFrm(MainFrm main)
        {
            _main = main;

            InitializeComponent();
        }

        #region IHaltable Implementation
        public void Halt()
        {
            throw new NotImplementedException();
        }
        public void Restore()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IReceiver Implementation
        public bool IsReceiving { get; }
        public void HandleOutgoing(DataInterceptedEventArgs e)
        {
            throw new NotImplementedException();
        }
        public void HandleIncoming(DataInterceptedEventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}