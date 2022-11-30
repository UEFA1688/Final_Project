namespace Test;

public class UnitTest1
{
    [Fact]
    public void TestReservationMenu()
    {
        MainMenu menu = new MainMenu();
        menu.RouteToMenu(AuthenMenu.Reservation);

        Assert.Equal(menu.Reservation(), true);

    }
    [Fact]
    public void TestListMenu()
    {
        MainMenu menu = new MainMenu();
        menu.RouteToMenu(AuthenMenu.List);

        Assert.Equal(menu.UserList(), true);

    }
    [Fact]
    public void TestShowAllMenu()
    {
        MainMenu menu = new MainMenu();
        menu.RouteToMenu(AuthenMenu.ShowAll);

        Assert.Equal(menu.ShowAll(), true);

    }
    [Fact]
    public void TestLogoutMenu()
    {
        MainMenu menu = new MainMenu();
        menu.RouteToMenu(AuthenMenu.Logout);

        Assert.Equal(menu.Logout(), true);

    }

}