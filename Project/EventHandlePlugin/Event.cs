﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlePlugin
{
    public abstract class Event
    {
        public abstract EventMessage getMessage();
    }
}
