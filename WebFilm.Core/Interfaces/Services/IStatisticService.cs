﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFilm.Core.Enitites.Statistic;

namespace WebFilm.Core.Interfaces.Services
{
    public interface IStatisticService
    {
        StatisticResponse GetStatistic();
    }
}
