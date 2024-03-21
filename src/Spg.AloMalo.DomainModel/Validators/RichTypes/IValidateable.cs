﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AloMalo.DomainModel.Validators.RichTypes
{
    public interface IValidateable<TRichType>
    {
        (bool, string?) IsValid();
    }
}
