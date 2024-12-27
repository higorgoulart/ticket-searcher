# Ticket Searcher 🎟️

A .NET 8 application that uses Selenium to automate the process of checking ticket availability for events. This bot continuously monitors a ticket sales website and notifies the user when a specific ticket becomes available.

## 🚀 Features

Built with .NET 8 for performance and reliability.

Automates web interaction with Selenium WebDriver.

Configurable to search for specific events or ticket types.

Sends notifications when desired tickets are available.

Efficient and fast, running checks at regular intervals.

## 🎸 Why I Built This

I developed this bot to secure tickets for a System of a Down concert when they sold out quickly. Thanks to this bot, I managed to grab the tickets as soon as they became available again!

## 🛠️ How It Works

The bot launches a browser using Selenium.

It navigates to the ticketing website and performs searches for specific events.

If a ticket matching the criteria is found, the bot triggers a notification.

## 📋 Requirements

.NET 8 SDK

Selenium WebDriver

A supported web browser (Chrome, Firefox, Edge, etc.)

## 🧑‍💻 Setup and Usage

Clone the repository:

```
git clone https://github.com/yourusername/ticket-searcher.git
```

Install dependencies:

```
dotnet restore
```

Configure the bot in the appsettings.json file.

Run the application:

```
dotnet run --project TicketSearcher/TicketSearcher.csproj
```

## 🚨 Disclaimer

Use this bot responsibly. Automating ticket purchases may violate the terms of service of some websites.

I am not responsible for any misuse or potential bans.

##

Feel free to fork, modify, and contribute!

