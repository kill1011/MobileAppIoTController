﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using MobileAppIoTController.Services;
using MobileAppIoTController.Services.Interfaces;
using MobileAppIoTController.ViewModels;
using Syncfusion.Maui.Core.Hosting;

namespace MobileAppIoTController
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit() // Ensure CommunityToolkit is initialized
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.ConfigureSyncfusionCore();
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<SwitchStatesViewModel>();
            builder.Services.AddSingleton<TemperatureViewModel>();
            builder.Services.AddSingleton<TextMessageViewModel>();
            builder.Services.AddSingleton<IIoTService, FirebaseIoTService>();
            return builder.Build();
        }
    }
}