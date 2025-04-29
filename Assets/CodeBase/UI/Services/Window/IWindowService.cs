﻿using CodeBase.UI.AbstractWindow;
using CodeBase.UI.Controllers;

namespace CodeBase.UI.Services.Window
{
    public interface IWindowService
    {
        void Bind<TWindow, TController>()
            where TWindow : AbstractWindowBase
            where TController : IController<TWindow>;

        void Bind<TWindow, TController, TModel>()
            where TWindow : AbstractWindowBase
            where TModel : AbstractWindowModel
            where TController : IModelBindable;

        TWindow OpenWindow<TWindow>() where TWindow : AbstractWindowBase;
        void Hide<TWindow>() where TWindow : AbstractWindowBase;
    }
}