﻿using System;
using System.Collections.Generic;

namespace Service.Core.DAL.Models
{
    public partial class AspNetUserLogins
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public string UserId { get; set; }
        public DateTimeOffset? SysChgDate { get; set; }
        public string SysChgLogin { get; set; }
        public string SysChgType { get; set; }
        public int? SysChgCnt { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
