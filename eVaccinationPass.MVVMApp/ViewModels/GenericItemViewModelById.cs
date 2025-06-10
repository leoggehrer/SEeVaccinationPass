﻿//@CodeCopy
#if EXTERNALGUID_OFF
using Avalonia.Controls.ApplicationLifetimes;
using eVaccinationPass.MVVMApp.Views;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System;
using Avalonia;

namespace eVaccinationPass.MVVMApp.ViewModels
{
    partial class GenericItemViewModel<TModel>
    {
        protected virtual async void Save()
        {
            bool canClose = false;
            using var httpClient = CreateHttpClient();

            try
            {
                if (Model.Id == default)
                {
                    var response = httpClient.PostAsync(RequestUri, new StringContent(JsonSerializer.Serialize(Model), Encoding.UTF8, "application/json")).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        canClose = true;
                    }
                    else
                    {
                        var messageDialog = new MessageDialog("Fehler", "Beim Speichern ist ein Fehler aufgetreten!", MessageType.Error);
                        var mainWindow = (Application.Current?.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)?.MainWindow;

                        await messageDialog.ShowDialog(mainWindow!);
                        Console.WriteLine($"Fehler beim Abrufen von {RequestUri}. Status: {response.StatusCode}");
                    }
                }
                else
                {
                    var response = httpClient.PutAsync($"{RequestUri}/{Model.Id}", new StringContent(JsonSerializer.Serialize(Model), Encoding.UTF8, "application/json")).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        canClose = true;
                    }
                    else
                    {
                        Console.WriteLine($"Fehler beim Abrufen von {RequestUri}. Status: {response.StatusCode}");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            if (canClose)
            {
                CloseAction?.Invoke();
            }
        }
    }
}
#endif
