﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Ramo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
