﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BootstrapBlazor.Components;
using Xm.Abp.BootstrapBlazorUI.Components;

namespace Xm.Abp.AspnetCore.Components.Web.BootstrapBlazorTheme.PageToolbars;

public static class PageToolbarExtensions
{
    public static PageToolbar AddComponent<TComponent>(
        this PageToolbar toolbar,
        Dictionary<string, object> arguments = null,
        int order = 0,
        string requiredPolicyName = null)
    {
        return toolbar.AddComponent(
            typeof(TComponent),
            arguments,
            order,
            requiredPolicyName
        );
    }

    public static PageToolbar AddComponent(
        this PageToolbar toolbar,
        Type componentType,
        Dictionary<string, object> arguments = null,
        int order = 0,
        string requiredPolicyName = null)
    {
        toolbar.Contributors.Add(
            new SimplePageToolbarContributor(
                componentType,
                arguments,
                order,
                requiredPolicyName
            )
        );

        return toolbar;
    }

    public static PageToolbar AddButton(
        this PageToolbar toolbar,
        string text,
        Func<Task> clicked,
        object icon = null,
        Color color = Color.Primary,
        bool disabled = false,
        int order = 0,
        string requiredPolicyName = null)
    {
        toolbar.AddComponent<ToolbarButton>(
            new Dictionary<string, object>
            {
                    { nameof(ToolbarButton.Color), color},
                    { nameof(ToolbarButton.Text), text},
                    { nameof(ToolbarButton.Disabled), disabled},
                    { nameof(ToolbarButton.Icon), icon},
                    { nameof(ToolbarButton.Clicked),clicked},
            },
            order,
            requiredPolicyName
        );

        return toolbar;
    }
}
