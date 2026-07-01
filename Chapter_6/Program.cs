using Chapter_6._01_Introduction_Strategy;
using Chapter_6._02_Benefits_Strategy;
using Chapter_6._03_Implementation_Strategy;
using Chapter_6._03_Implementation_Strategy.BattleStrategy;
using Chapter_6._03_Implementation_Strategy.FastUnit;
using Chapter_6._03_Implementation_Strategy.LogStrategy;
using Chapter_6._03_Implementation_Strategy.PaymentStrategy;
using Chapter_6._04_PracticalExamples_Strategy.AttackStrategy;
using Chapter_6._04_PracticalExamples_Strategy.MovementStrategy;
using Chapter_6._05_Sorting_Strategies.SortStrategy;
using Chapter_6._07_Introduction_Observer;
using Chapter_6._09_Implementation_Observer.HeadlineSubscriber;
using Chapter_6._09_Implementation_Observer.WeatherListener;
using Chapter_6._10_Examples_Notification_Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to part 1 - Introduction to Strategy
            var vacuum = new Navigator(new SpiralMovement());
            vacuum.Navigate(); // Output: Sweeping the room in a spiral...

            vacuum.MovementMode = new WallFollowingMovement();
            vacuum.Navigate(); // Output: Following along the walls like a shadow...

            //to part 2 - Benefits of Strategy
            var archiver = new ArchiveTool(new ZipCompression());
            archiver.ExecuteCompression(); // Compressing using ZIP format...

            archiver.SetStrategy(new RarCompression());
            archiver.ExecuteCompression(); // Compressing using RAR format...

            //to part 3 - Battle Strategy
            var knight = new Unit(new AggressiveAttack());
            knight.Engage(); // Charging into battle with full force!

            knight.SetStrategy(new DefensiveRetreat());
            knight.Engage(); // Retreating strategically to avoid unnecessary losses.

            //to part 3 - Payment Strategy
            var checkout = new CheckoutContext(new CreditCardPayment());
            checkout.Checkout(129.99m); // Charging $129.99 to credit card...

            checkout.SetPaymentMethod(new PayPalPayment());
            checkout.Checkout(59.50m);  // Redirecting to PayPal for $59.50...

            //to part 3 - Logging Strategy
            var logger = new Logger(new ConsoleLogger());
            logger.Log("App started.");  // [Console]: App started.

            logger.SetLogger(new FileLogger());
            logger.Log("User logged in."); // [File]: Writing 'User logged in.' to log.txt

            //to part 3 - FastUnit
            var fastUnit = new FastUnit(() => Console.WriteLine("Performing a lightning-fast strike!"));
            fastUnit.Act();

            fastUnit.SetAction(() => Console.WriteLine("Dodging back quickly!"));
            fastUnit.Act();

            //to part 4 - Movement Strategy
            var knight1 = new Character("Sir Cedric", new AggressiveRush());
            var archer = new Character("Elira", new FlankingManeuver());
            var mage = new Character("Vaelir", new Teleportation());

            knight1.Move(); // Sir Cedric charges directly into the enemy ranks!
            archer.Move(); // Elira moves silently to flank the enemy from the side.
            mage.Move();   // Vaelir disappears and reappears behind enemy lines.

            knight1.SetMovementStrategy(new FlankingManeuver());
            knight1.Move(); // Sir Cedric moves silently to flank the enemy from the side.

            //to part 4 - Attack Strategy
            var rogue = new BattleUnit("Kael", new FlankingManeuver(), new MeleeStrike());
            rogue.Move();   // Kael moves silently to flank the enemy from the side.
            rogue.Attack(); // Kael swings a sword with brute force!

            rogue.SetAttackStrategy(new ArcaneBlast());
            rogue.Attack(); // Kael unleashes a blast of raw magical energy.

            //to part 5 - Sorting Strategy
            var names = new List<string> { "Zara", "Eli", "Anna", "Ben" };
            var nameSorter = new Sorter<string>(new AlphabeticalSort());
            var sortedNames = nameSorter.Sort(names);

            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);
            }

            var products = new List<Product>
            {
                new Product { Name = "Keyboard", Price = 49.99m },
                new Product { Name = "Monitor", Price = 149.99m },
                new Product { Name = "Mouse", Price = 19.99m }
            };

            var productSorter = new Sorter<Product>(new PriceSort());
            var sortedProducts = productSorter.Sort(products);

            foreach (var p in sortedProducts)
            {
                Console.WriteLine($"{p.Name} - ${p.Price}");
            }

            //to part 7 - Introduction to Observer
            var ticker = new PriceBroadcaster();

            var alice = new PriceSubscriber("Alice");
            var bob = new PriceSubscriber("Bob");

            ticker.Register(alice);
            ticker.Register(bob);

            ticker.SetPrice(120.50m);
            // [Ticker] New stock price: $120.50
            // [Alice] Received price update.
            // [Bob] Received price update.

            //to part 9 - Weather
            var station = new WeatherStation();
            var console1 = new ConsoleDisplay("Main Panel");
            var console2 = new ConsoleDisplay("Secondary Display");

            station.Register(console1);
            station.Register(console2);

            station.SetTemperature(22.5);
            // Output:
            // [Main Panel] Current temperature: 22.5°C
            // [Secondary Display] Current temperature: 22.5°C

            var station1 = new EventDrivenWeatherStation();

            station1.TemperatureChanged += temp =>
            {
                Console.WriteLine($"[Console] It's now {temp}°C outside!");
            };

            station1.SetTemperature(18.3);
            // Output:
            // [Console] It's now 18.3°C outside!

            //to part 9 - HeadlineSubscriber
            var news = new NewsPublisher();

            var user1 = new HeadlineSubscriber("Alice");
            var user2 = new HeadlineSubscriber("Bob");

            var token1 = news.Subscribe(user1);
            var token2 = news.Subscribe(user2);

            news.PublishHeadline("New chapter in C# book released!");
            // Output:
            // [Alice] New headline: New chapter in C# book released!
            // [Bob] New headline: New chapter in C# book released!

            token2.Dispose(); // Bob unsubscribes

            news.PublishHeadline("Observer pattern spotted in the wild!");
            // Output:
            // [Alice] New headline: Observer pattern spotted in the wild!

            //to part 10 - Notification
            var notifier = new UserNotifier();
            notifier.Register(new EmailChannel());
            notifier.Register(new SmsChannel());
            notifier.Register(new PushNotificationChannel());

            var signup = new UserSignupService(notifier);
            signup.RegisterNewUser("sergii");
            // Output:
            // User 'sergii' registered.
            // [Email] Sending email: Welcome, Tom!
            // [SMS] Sending SMS: Welcome, Tom!
            // [Push] Sending push notification: Welcome, Tom!


        }
    }
}
