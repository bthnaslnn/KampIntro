﻿using GameProject;

internal class Program
{
    private static void Main(string[] args)
    {
        GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
        gamerManager.Add(new Gamer
        {
            Id = 1,
            BirthYear = 1985,
            FirstName = "BATUHAN",
            LastName = "ASLAN",
            IdentityNumber = 12345
        });

    }

}