﻿using System;
using System.Collections.Generic;

namespace Practica7032025.APPMVDatabaseFirst.Models;

public partial class Equipo
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }
}
