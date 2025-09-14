using MusicStoreApp.data;
using MusicStoreApp.gui;

namespace MusicStoreApp;

internal static class Program
{
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        // Application.Run(new UserMainWindow());
        Application.Run(new LoginWindow());
        DatabaseHandler.Connect();
        DatabaseHandler.LoadUsers();
        DatabaseHandler.LoadProducts();
        DatabaseHandler.LoadOrders();
        DatabaseHandler.LoadFavorites(); // TODO: Load Favorites
    }
}