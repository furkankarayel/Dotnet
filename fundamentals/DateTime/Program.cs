﻿﻿using System.Globalization;

DateTime dateOfBirth = new DateTime(1995, 6, 6);
Console.WriteLine(dateOfBirth.DayOfWeek);

// Computed Values
DateTime today = DateTime.Today;
DateTime now = DateTime.Now;
DateTime utcNow = DateTime.UtcNow;

// DateTime Parsing
DateTime localDate = DateTime.Parse("07.06.1990", new CultureInfo("de-DE"));

DateTime usDate = DateTime.Parse("06/07/1990", new CultureInfo("en-US"));

Console.WriteLine($"localDate: {localDate}, usDate: {usDate}");

// DateTime Formatting
Console.WriteLine(dateOfBirth.ToString());
Console.WriteLine(dateOfBirth.ToString(new CultureInfo("en-US")));
Console.WriteLine(dateOfBirth.ToString("yyyy-MM-dd"));