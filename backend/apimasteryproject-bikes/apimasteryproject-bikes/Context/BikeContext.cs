using apimasteryproject_bikes.Models;
using Microsoft.EntityFrameworkCore;

namespace apimasteryproject_bikes.Context
{
    public class BikeContext : DbContext
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Bicycle> Bicycles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=apimasteryproject-bikes;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
            //.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer(1, "Specialized", "./Images/Specializedlogo.jpg", "Specialized is an independent US-based bike manufacturer that has been around for 40+ years. Specialized Bicycle Components, Inc., more commonly known simply as Specialized, is a major American brand of bicycles and related products. It was founded in 1974 by Mike Sinyard and is based in Morgan Hill, California."),
                new Manufacturer(2, "Trek", "./Images/Treklogo.jpg", "Trek Bicycle Corporation is a bicycle and cycling product manufacturer and distributor under brand names Trek, Electra Bicycle Company, Gary Fisher, Bontrager, Diamant Bikes, Villiger Bikes and, until 2008, LeMond Racing Cycles and Klein. With its headquarters in Waterloo, Wisconsin, Trek bicycles are marketed through 1,700 dealers across North America, subsidiaries in Europe and Asia as well as distributors in 90 countries worldwide. 99% of Trek bicycles are manufactured outside the United States, in countries including the Netherlands, Germany, Taiwan and China."),
                new Manufacturer(3, "Cannondale", "./Images/Cannondalelogo.jpg", "The company was founded in 1971 by Joe Montgomery and Murdock MacGregor to manufacture precast concrete housing. Then Joe Montgomery, after a camping bike trip with his son, conceived the Bugger bicycle trailer. Ron Davis devised the under-seat hitch, a torsion spring made of Lexan. Wistrand designed the cloth bags and cargo carrier on the two models of trailers. Joe, in an effort repeated in numerous products, sourced the cloth components and ensured perfection in their manufacture. A trip to the Bicycle Show in New York was an eye opener."),
                new Manufacturer(5, "Kona", "./Images/Konalogo.jpg", "Kona Bikes is a bicycle company based in the Pacific Northwest. The company was founded in 1988 by Dan Gerhard and Jacob Heilbron in Vancouver, British Columbia, Canada."),
                new Manufacturer(6, "Transition", "./Images/Transitionlogo.jpg", "Depending on who you ask, Transition Bikes was either established in 2001 or in 2003. It's a long-running debate between Kyle Young and Kevin Menard, the company's founders. Kevin says it was in 2001, when the idea of starting a bike company came to the surface over a game of ping-pong, while Kyle asserts that it was 2003, when the first shipment of 100 bikes arrived in the US."),
                new Manufacturer(7, "Orange", "./Images/Orange.jpg", "BUILT IN BRITAIN, We work with partners all over the world to source many of our our frames and components, today we’re talking specifically about the British built models.We started production of our full - suspension frames in Halifax in 1998.It seemed the easiest way to get the development we needed for the frame ideas we were pursuing.Well it turned out not to be ‘easy’, but it did turn out to be successful, and the rest, as they say, is history. Since those intrepid beginnings we have built a lot of frames and learned plenty.While experience has taught us a lot, the little tweaks and tricks that we have learned in the building process aren’t necessarily obvious in the final frame, but they are crucial steps to producing some of the strongest and most reliable high - performance mountain bikes in the world. IT’S NOT SO SIMPLE The best ideas are always the simplest, right ? In bike development terms the Orange bikes are just that, a great idea done simply, but more importantly done well. We are often asked why we don’t make frames the same as everyone else. Well, thanks for asking but we really like the the way we do it.And so do the people who buy Orange bikes and try to ride the wheels off them. We simply build bikes to be ridden not to be hung on the wall and admired(although you can do that too, if you want). While we are open-minded to new ideas, we’re adamant about ensuring change is for the better and not just a marketing fad.We use our STrange R & D prototype program to sort the wheat from the chaff. ")
                )
                ;

            modelBuilder.Entity<Bicycle>().HasData(
                new Bicycle(1, "S-Works Shiv", "./Images/Specializedsworksshiv.jpg", "On the bike leg of any triathlon, speed and efficiency win the game. The S-Works Shiv is the ultimate speed weapon for any triathlon distance, and it's purpose-built to take your bike leg to the next level.", "TT", 1),
                new Bicycle(2, "Boone", "./Images/Trekboone.jpg", "Boone is our fastest, smoothest, lightest Cross bike ever, with competition-crushing race geometry and our exclusive course-smoothing IsoSpeed technology. Smooth and balanced. Front and Rear IsoSpeed make easy work of the roughest courses. These innovative decouplers reduce jarring impacts so you ride stronger, longer.", "Cyclocross", 2),
                new Bicycle(3, "SystemSix", "./Images/Cannondalesystemsix.jpg", "SystemSix is truly in a class of its own. Newly crowned 2019 Race Bike of the Year by BikeRadar/Cycling Plus Magazine and the fastest bike tested by Tour Magazine.", "Road", 3),
                new Bicycle(4, "Big Bird", "./Images/Focusbigbird.jpg", "After three years of intensive development, FOCUS have finally lifted the veil of secrecy and revealed the latest stage of mountain biking’s evolution. Alongside the FOCUS XC Team and Florian Vogel, this super-sized bike has come out of development and onto the market. Bike developers and pros stand united: this racing machine marks a milestone in mountain biking history. The Cloppenburg-based brand have once again redefined comfort, speed and grip.", "Mountain", 4),
                new Bicycle(5, "Izalco Chrono", "./Images/Focusizalcochrono.jpg", "Hard and fast flat-course machine for aggressive athletes prepared to sacrifice comfort for all-out speed. Co-created five years ago by Andreas Walser, one of Europe’s top custom aero frame-builders, can the minimal-profile Focus Izalco Chrono 2.0 20-G still slice its way through the air and the competition?", "TT", 4),
                new Bicycle(6, "KonaSutra", "./Images/Konasutra.jpg", "The Sutra is many things. It's gorgeous. It's stylish. It's incredibly versatile, and it comes ready for the long haul on the bike tour of your dreams. Our Kona Cromoly steel frame is outfitted with a Brooks saddle, cork bar tape, BarCon shifters, fenders and rack.", "Commuter", 5),
                new Bicycle(7, "Patrol Carbon X01", "./Images/Transitionpatrol.jpg", "Being one of our most versatile bikes in the lineup, it was a natural fit to take the suspension to the next level. ... If you need your bike to be a daily driver for your local trails as well as your bike park and shuttle session steed, the Patrol is the perfect choice.", "Mountain", 6),
           
                new Bicycle(8, "Orange Crush", "./Images/OrangeCrush.jpg", "The Orange Crush is a bike you don't want to mess with. It's loved and revered, with award winning performance. It's the definitive aluminium hardcore hardtail. The frame is bang on point, the rear triangle features a 148 Boost bolt - through axle, giving unparalleled stability to what is already a strong and rigid chassis.The new model's geometry has been tweaked with a 64° head angle which, matched with the Crush’s long top tube design, adds an extra degree of confidence in the handling. With a short 50mm stem the rider is right where they need to be for direct control and weight distribution. Short chainstays make climbing as sweet as ever for a long-forked hardtail, those stays now reshaped with a CNCed yoke on the chainstay to allow plenty of clearance for a more than chunky 2.6 tyre. The Crush’s unshakeable attitude is as strong as ever.Built tough to be ridden hard, where it really excels, on the rough stuff.", "Mountain", 7)
                     );
            base.OnModelCreating(modelBuilder);
        }

    }
}
