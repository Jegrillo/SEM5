﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LR_Eight
{
    class Notebook : ComputerTechnology
    {
        
        public Notebook()
            : base()
        {
            Model = Models.Нет_модели;
        }

        public Notebook(string M, int PY, int P, Models Mod)
            :base(M, PY, P)
        {
            Model = Mod;
        }

        public Models Model;

        public override string MPPY
        {
            get
            {
                return (Model.ToString()); 
            }
        }

    }
}
