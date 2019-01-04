﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hass.Client.ViewModels
{
    public interface IShellContext
    {
        void BeginInvokeInMainThread(Action action);

        Task PushAsync(IViewModel viewModel);

        Task PushModalAsync(IModalViewModel viewModel);
    }


}
