﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samba.Infrastructure;
using Samba.Infrastructure.Data;

namespace Samba.Domain.Models.Accounts
{
    public class AccountScreen : EntityClass
    {
        public AccountScreen()
        {
            _accountScreenValues = new List<AccountScreenValue>();
        }

        public int Filter { get; set; }
        public bool DisplayAsTree { get; set; }

        private IList<AccountScreenValue> _accountScreenValues;
        public virtual IList<AccountScreenValue> AccountScreenValues
        {
            get { return _accountScreenValues; }
            set { _accountScreenValues = value; }
        }

    }
}
