﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab_8
{
    interface IStack<T>
    {
        public void AddEl(T data);
        public void DelEl();
        public void SeeAll();
    }
}
